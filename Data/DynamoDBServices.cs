using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWS_ElasticBeanstalk_Project.Models;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.AspNetCore.Mvc;

namespace AWS_ElasticBeanstalk_Project.Data
{
    public class DynamoDBServices
    {
        IAmazonDynamoDB dynamoDBClient { get; set; }

        private static IAmazonDynamoDB client = new AmazonDynamoDBClient(Amazon.RegionEndpoint.USEast1);
        private static DynamoDBContext context = new DynamoDBContext(client);

        public DynamoDBServices(IAmazonDynamoDB dynamoDBClient)
        {
            this.dynamoDBClient = dynamoDBClient;
        }

        public DynamoDBServices()
        {
            this.dynamoDBClient = client;
        }

        public async Task<Video> InsertVideo(Video video)
        {
            DynamoDBContext context = new DynamoDBContext(dynamoDBClient);
            // Add a unique id for the primary key.
            video.VideoId = System.Guid.NewGuid().ToString();
            await context.SaveAsync(video, default(System.Threading.CancellationToken));
            Video newVideo = await context.LoadAsync<Video>(video.VideoId, default(System.Threading.CancellationToken));
            return video;
        }

        public async Task<Video> GetVideoAsync(string Id)
        {
            DynamoDBContext context = new DynamoDBContext(dynamoDBClient);
            Video newVideo = await context.LoadAsync<Video>(Id, default(System.Threading.CancellationToken));


            return newVideo;
        }

        public async Task<Video> UpdateVideoAsync(Video video)
        {
            DynamoDBContext context = new DynamoDBContext(dynamoDBClient);
            await context.SaveAsync(video, default(System.Threading.CancellationToken));
            Video newVideo = await context.LoadAsync<Video>(video.VideoId, default(System.Threading.CancellationToken));
            return newVideo;
        }
        public async Task DeleteVideoAsync(string Id)
        {
            DynamoDBContext context = new DynamoDBContext(dynamoDBClient);
            await context.DeleteAsync(Id, default(System.Threading.CancellationToken));
        }
        public async Task<List<Video>> GetVideosAsync()
        {
            ScanFilter scanFilter = new ScanFilter();
            scanFilter.AddCondition("VideoId", ScanOperator.NotEqual, 0);

            ScanOperationConfig soc = new ScanOperationConfig()
            {
                // AttributesToGet = new List { "Id", "Title", "ISBN", "Price" },
                Filter = scanFilter
            };
            DynamoDBContext context = new DynamoDBContext(dynamoDBClient);
            AsyncSearch<Video> search = context.FromScanAsync<Video>(soc, null);
            List<Video> documentList = new List<Video>();
            do
            {
                documentList = await search.GetNextSetAsync(default(System.Threading.CancellationToken));
            } while (!search.IsDone);

            return documentList;
        }



        public async Task<User> GetUserAsync(string userId)
        {
            DynamoDBContext context = new DynamoDBContext(dynamoDBClient);
            User user = await context.LoadAsync<User>(userId, default(System.Threading.CancellationToken));
            return user;
        }
    }
}
