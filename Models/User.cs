using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWS_ElasticBeanstalk_Project.Models
{
    [DynamoDBTable("UserInfo")]
    public class User
    {

        [DynamoDBHashKey]    //Partition key
        public string UserId { get; set; }
        [DynamoDBProperty]  
        public string Password { get; set; }

    }
}

