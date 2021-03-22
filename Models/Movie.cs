using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;

namespace AWS_ElasticBeanstalk_Project.Models
{
    [DynamoDBTable("Movie")]
    public class Movie
    {
        [DynamoDBHashKey]    //Partition key
        public string Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Duration { get; set; }
        public string MovieCategory { get; set; }
        public bool InPublication { get; set; }

    }
}
