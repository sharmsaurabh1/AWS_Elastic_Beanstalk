using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWS_ElasticBeanstalk_Project.Models
{
    [DynamoDBTable("VideoInfo")]
    public class Video
    {

        [DynamoDBHashKey]    //Partition key
        public string VideoId { get; set; }
        [DynamoDBProperty]
        public string Title { get; set; }
        [DynamoDBProperty]
        public string Type { get; set; }
        [DynamoDBProperty]
        public decimal OverallRating { get; set; }

        [DynamoDBProperty]
        public string Commnt { get; set; }
        [DynamoDBProperty]
        public S3Link VideoFileLink { get; set; }

        public virtual string VideoFile { get; set; }

        [DynamoDBProperty(typeof(AwsCommentConverter))]
        public List<Comment> Comments { get; set; }
    }

    public class Comment
    {
        public string CommentId { get; set; }
        public decimal Rating { get; set; }
        public string UserId { get; set; }
        public string CommentContent { get; set; }

    }

    public class AwsCommentConverter : IPropertyConverter
    {
        public object FromEntry(DynamoDBEntry entry)
        {
            PrimitiveList primList = entry as PrimitiveList;
            if (primList == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            List<Comment> comments = new List<Comment>();
            foreach (string s in primList.AsListOfString())
            {
                string[] data = s.Split(new string[] { "$~$" }, StringSplitOptions.None);
                if (data.Length != 4)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Comment record = new Comment
                {
                    CommentId = Convert.ToString(data[0]),
                    Rating = Convert.ToDecimal(data[1]),
                    UserId = Convert.ToString(data[2]),
                    CommentContent = Convert.ToString(data[3])
                };
                comments.Add(record);

            }
            return comments;
        }
        public DynamoDBEntry ToEntry(object value)
        {
            List<Comment> comments = value as List<Comment>;
            List<Primitive> storageVals = new List<Primitive>();

            foreach (Comment cm in comments)
            {
                string dta = cm.CommentId + "$~$" + cm.Rating + "$~$" + cm.UserId + "$~$" + cm.CommentContent;
                storageVals.Add(new Primitive() { Value = dta });
            }
            return new PrimitiveList() { Entries = storageVals };
        }
    }
}

