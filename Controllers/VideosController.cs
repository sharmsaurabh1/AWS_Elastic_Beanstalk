using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWS_ElasticBeanstalk_Project.Data;
using AWS_ElasticBeanstalk_Project.Models;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AWS_ElasticBeanstalk_Project.Controllers
{
    public class VideosController : Controller
    {
        public IAmazonDynamoDB dynamoDBClient;
        //public DynamoDBContext dbContext;

        private static AmazonDynamoDBClient client = new AmazonDynamoDBClient(Amazon.RegionEndpoint.USEast1);
        private static DynamoDBContext dbContext = new DynamoDBContext(client);

        string refUserId = "";

        public VideosController()
        {
            IAmazonDynamoDB dynamoDBClient = new AmazonDynamoDBClient(Amazon.RegionEndpoint.USEast1);
            //_context = context;
            this.dynamoDBClient = dynamoDBClient;
            //this.dbContext = new DynamoDBContext(dynamoDBClient);
        }

        // GET: Books
        public async Task<IActionResult> Index(string userId)
        {
            DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
            refUserId = userId;
            if (string.IsNullOrEmpty(userId))
            {
                ViewData["userId"] = "";
                TempData["userId"] = "";
            }
            else
            {
                ViewData["userId"] = userId;
                TempData["userId"] = userId;
            }
            return View(await service.GetVideosAsync());

        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(string id, string userId)
        {
            if (id == null)
            {
                return NotFound();
            }

            DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
            Video video = await service.GetVideoAsync(id);

            if (video == null)
            {
                return NotFound();
            }

            refUserId = userId;
            if (string.IsNullOrEmpty(userId))
            {
                ViewData["userId"] = "";
            }
            else
            {
                ViewData["userId"] = userId;
            }

            return View(video);
        }

        // GET: Books/Create
        public IActionResult Create(string userId)
        {
            string refUserId = (string)TempData["userId"];
            refUserId = userId;
            if (string.IsNullOrEmpty(userId))
            {
                ViewData["userId"] = "";
            }
            else
            {
                ViewData["userId"] = userId;
            }

            return View();
        }

        // POST: Books/Create

        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> Create([Bind("VideoId, Title, Type, OverallRating, VideoFileLink, VideoFile, Commnt,Comments")] Video video)
        {
            string userId = (string)TempData["userId"];

            if (ModelState.IsValid)
            {

                string bucketName = "####################";
                video.VideoFileLink = S3Link.Create(dbContext, bucketName, video.VideoFile, Amazon.RegionEndpoint.USEast1);

                DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
                Video newVideo = await service.InsertVideo(video);

                uploadVidoetoBucket(video.VideoFile);

                return RedirectToAction("Index");
            }
            refUserId = userId;
            if (string.IsNullOrEmpty(userId))
            {
                ViewData["userId"] = "";
            }
            else
            {
                ViewData["userId"] = userId;
            }
            return View(video);
        }


        public async void uploadVidoetoBucket(string videoFileName)
        {
            string keyName = videoFileName;
            string filePath = @"/" + videoFileName;


            string accessId = "###########################";
            string secretKey = "#####################################";
            string bucketName = "##########";

            try
            {
                var credential = new BasicAWSCredentials(accessId, secretKey);

                using (AmazonS3Client s3Client = new AmazonS3Client(credential, RegionEndpoint.USEast1))
                {
                    PutObjectRequest putRequest = new PutObjectRequest
                    {
                        BucketName = bucketName,
                        Key = keyName,
                        FilePath = filePath
                    };

                    PutObjectResponse response = await s3Client.PutObjectAsync(putRequest);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(string id, string userId)
        {
            if (id == null)
            {
                return NotFound();
            }

            DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
            Video video = await service.GetVideoAsync(id);

            refUserId = userId;
            if (string.IsNullOrEmpty(userId))
            {
                ViewData["userId"] = "";
            }
            else
            {
                ViewData["userId"] = userId;
            }

            if (video == null)
            {
                return NotFound();
            }
            return View(video);
        }

        // POST: Books/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VideoId, Title, Type, OverallRating, VideoFileLink, Comments")] Video video)
        {
            if (id != video.VideoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
                    Video newVideo = await updatevideo(video, service);
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction("Index");
            }
            string userId = (string)TempData["userId"];

            if (string.IsNullOrEmpty(userId))
            {
                ViewData["userId"] = "";
            }
            else
            {
                ViewData["userId"] = userId;
            }
            return View(video);
        }

        private static async Task<Video> updatevideo(Video video, DynamoDBServices service)
        {
            return await service.UpdateVideoAsync(video);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
            Video video = await service.GetVideoAsync(id);
            if (video == null)
            {
                return NotFound();
            }

            return View(video);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string Id)
        {
            DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
            await service.DeleteVideoAsync(Id);
            return RedirectToAction(nameof(Index));
        }
    }

}
