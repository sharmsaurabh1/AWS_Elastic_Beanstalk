using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWS_ElasticBeanstalk_Project.Data;
using AWS_ElasticBeanstalk_Project.Models;
using Amazon.DynamoDBv2;

using Microsoft.AspNetCore.Mvc;

namespace AWS_ElasticBeanstalk_Project.Controllers
{
    public class LoginController : Controller
    {
        public IAmazonDynamoDB dynamoDBClient = new AmazonDynamoDBClient(Amazon.RegionEndpoint.USEast1);
        public LoginController()
        {

        }
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login([Bind("UserId, Password")] User user)
        {
            if (ModelState.IsValid)
            {
                DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
                User userInfo = await service.GetUserAsync(user.UserId);

                if (userInfo == null)
                {
                    ViewData["errorMessage"] = "UserId or Password is not correct. Please try again";
                    return View();
                }
                else if (userInfo.Password != user.Password)
                {
                    ViewData["errorMessage"] = "UserId or Password is not correct. Please try again";
                    return View();
                }
                else if (userInfo.UserId == user.UserId && userInfo.Password == user.Password)
                {
                    return RedirectToAction("Index", "Videos", new { userId = userInfo.UserId });
                }
            }
            return View(user);
        }



    }
}
