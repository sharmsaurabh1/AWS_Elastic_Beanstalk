using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AWS_ElasticBeanstalk_Project.Models;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Microsoft.Net.Http.Headers;
using System.IO;

namespace AWS_ElasticBeanstalk_Project.Controllers
{
    public class HomeController : Controller
    {
        IAmazonS3 S3Client { get; set; }
        private const string bucketName = "###################";

        public HomeController(IAmazonS3 s3Client)
        {
            this.S3Client = s3Client;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public async Task<ActionResult> UploadFile(IFormFile file)
        {
            var fileName = ContentDispositionHeaderValue
                .Parse(file.ContentDisposition)
                .FileName
                .TrimStart().ToString();




            bool status;
            using (var fileStream = file.OpenReadStream())
            using (var ms = new MemoryStream())
            {
                await fileStream.CopyToAsync(ms);
                status = await UploadFileAsync(ms, fileName, null);
            }
            //add status handling
            return RedirectToAction("Index");
        }
        public async Task<bool> UploadFileAsync(Stream fileStream, string fileName, string directory = null)
        {
            try
            {
                var fileTransferUtility = new TransferUtility(S3Client);


                var bucketPath = !string.IsNullOrWhiteSpace(directory)
                    ? bucketName + @"/" + directory
                    : bucketName;

                var fileUploadRequest = new TransferUtilityUploadRequest()
                {
                    CannedACL = S3CannedACL.PublicRead,
                    BucketName = bucketPath,
                    Key = fileName,
                    InputStream = fileStream
                };

                await fileTransferUtility.UploadAsync(fileUploadRequest);

                return true;
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                if (amazonS3Exception.ErrorCode != null &&
                    (amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId") ||
                     amazonS3Exception.ErrorCode.Equals("InvalidSecurity")))
                {
                    // add error logging
                }
                else
                {
                    //add error handling
                }
                return false;
            }
        }
    }
}
