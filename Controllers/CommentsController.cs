
using AWS_ElasticBeanstalk_Project.Data;
using AWS_ElasticBeanstalk_Project.Models;
using Amazon.DynamoDBv2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWS_ElasticBeanstalk_Project.Controllers
{
    public class CommentsController : Controller
    {

        private IAmazonDynamoDB dynamoDBClient;

        private static string refVideoId = "";

        public CommentsController()
        {
            IAmazonDynamoDB dynamoDBClient = new AmazonDynamoDBClient(Amazon.RegionEndpoint.USEast1);
            //_context = context;
            this.dynamoDBClient = dynamoDBClient;
        }

        // GET: Comments
        public async Task<IActionResult> Index(string videoId, string userId)
        {
            //string videoId = "";
            refVideoId = videoId;
            DynamoDBServices service = new DynamoDBServices(dynamoDBClient);

            if (string.IsNullOrEmpty(videoId))
            {
                return RedirectToAction("Index", "Videos");
            }

            Video video = await service.GetVideoAsync(videoId);

            if (string.IsNullOrEmpty(userId))
            {
                ViewData["userId"] = "";
            }
            else
            {
                ViewData["userId"] = userId;
            }

            if (string.IsNullOrEmpty(videoId))
            {
                ViewData["videoId"] = "";
            }
            else
            {
                ViewData["videoId"] = videoId;
            }

            return View(video.Comments);

        }

        // GET: Comments/Details/5
        public async Task<IActionResult> Details(string id, string videoId, string userId)
        {
            bool commentFound = false;
            Comment detailComment = new Comment();

            if (string.IsNullOrEmpty(userId))
            {
                ViewData["userId"] = "";
            }
            else
            {
                ViewData["userId"] = userId;
            }

            if (string.IsNullOrEmpty(videoId))
            {
                ViewData["videoId"] = "";
            }
            else
            {
                ViewData["videoId"] = videoId;
            }

            if (id == null)
            {
                return NotFound();
            }

            DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
            Video video = await service.GetVideoAsync(refVideoId);

            if (video == null)
            {
                return NotFound();
            }


            foreach (Comment comment in video.Comments)
            {
                if (comment.CommentId == id)
                {
                    commentFound = true;
                    detailComment = comment;
                }
            }

            if (commentFound == false)
            {
                return NotFound();
            }

            return View(detailComment);
        }

        // GET: Comments/Create
        public IActionResult Create(string videoId, string userId)
        {
            string hjh = (string)ViewData["userId"];

            if (string.IsNullOrEmpty(userId))
            {
                ViewData["userId"] = "";
            }
            else
            {
                ViewData["userId"] = userId;
            }

            if (string.IsNullOrEmpty(videoId))
            {
                ViewData["videoId"] = "";
            }
            else
            {
                ViewData["videoId"] = videoId;
            }
            return View();
        }

        // POST: Comments/Create
 
        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> Create([Bind("CommentId, Rating, UserId, CommentContent")] Comment newComment)
        {
            if (ModelState.IsValid)
            {
                DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
                Video video = await service.GetVideoAsync(refVideoId);

                newComment.CommentId = System.Guid.NewGuid().ToString();
                newComment.UserId = "1";

                if (video.Comments == null)
                {
                    video.Comments = new List<Comment>();
                }

                video.Comments.Add(newComment);

                decimal overallRating = 0;

                foreach (Comment comment in video.Comments)
                {
                    overallRating += comment.Rating;
                }

                video.OverallRating = Math.Truncate(overallRating / video.Comments.Count);

                //DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
                Video updatedVideo = await service.UpdateVideoAsync(video);
                return RedirectToAction("Index");
            }
            return View(newComment);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(string id, string videoId, string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                ViewData["userId"] = "";
            }
            else
            {
                ViewData["userId"] = userId;
            }

            if (string.IsNullOrEmpty(videoId))
            {
                ViewData["videoId"] = "";
            }
            else
            {
                ViewData["videoId"] = videoId;
            }

            if (id == null)
            {
                return NotFound();
            }

            Comment detailComment = new Comment();

            DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
            Video video = await service.GetVideoAsync(refVideoId);

            if (video == null)
            {
                return NotFound();
            }


            foreach (Comment comment in video.Comments)
            {
                if (comment.CommentId == id)
                {
                    detailComment = comment;
                    return View(detailComment);
                }
            }

            return View(detailComment);
        }

        // POST: Books/Edit/5
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CommentId, Rating, UserId, CommentContent")] Comment updatedComment)
        {
            if (id != updatedComment.CommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
                    Video video = await service.GetVideoAsync(refVideoId);

                    updatedComment.UserId = "1";

                    for (int i = 0; i < video.Comments.Count; i++)
                    {
                        if (video.Comments[i].CommentId == id)
                        {
                            video.Comments[i] = updatedComment;
                        }
                    }

                    decimal overallRating = 0;

                    foreach (Comment comment in video.Comments)
                    {
                        overallRating += comment.Rating;
                    }

                    video.OverallRating = Math.Truncate(overallRating / video.Comments.Count);

                    Video updatedVideo = await service.UpdateVideoAsync(video);

                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction("Index");
            }
            return View(updatedComment);
        }

        public async Task<IActionResult> Delete(string id)
        {
            //if (string.IsNullOrEmpty(userId))
            //{
            //    ViewData["userId"] = "";
            //}
            //else
            //{
            //    ViewData["userId"] = userId;
            //}

            //if (string.IsNullOrEmpty(videoId))
            //{
            //    ViewData["videoId"] = "";
            //}
            //else
            //{
            //    ViewData["videoId"] = videoId;
            //}

            if (id == null)
            {
                return NotFound();
            }


            DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
            Video video = await service.GetVideoAsync(refVideoId);
            Comment detailComment = new Comment();


            if (video == null)
            {
                return NotFound();
            }

            foreach (Comment comment in video.Comments)
            {
                if (comment.CommentId == id)
                {
                    detailComment = comment;
                    return View(detailComment);
                }
            }

            return View(detailComment);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            DynamoDBServices service = new DynamoDBServices(dynamoDBClient);
            Video video = await service.GetVideoAsync(refVideoId);

            for (int i = 0; i < video.Comments.Count; i++)
            {
                if (video.Comments[i].CommentId == id)
                {
                    video.Comments.RemoveAt(i);
                }
            }

            decimal overallRating = 0;

            foreach (Comment comment in video.Comments)
            {
                overallRating += comment.Rating;
            }

            video.OverallRating = Math.Truncate(overallRating / video.Comments.Count);

            Video updatedVideo = await service.UpdateVideoAsync(video);

            return RedirectToAction(nameof(Index));
        }
    }
}
