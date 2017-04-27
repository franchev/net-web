using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.API.Helpers
{
    public class awsData 
    {
        public List<string> GetRegions()
        {
            List<string> regionList = new List<string>();
            var regions = RegionEndpoint.EnumerableAllRegions;
            foreach (var region in regions)
            {
                regionList.Add(region.SystemName);
            }

            return regionList;

        }

        private RegionEndpoint GetEndPointAssociationToRegion(string region)
        {
            return RegionEndpoint.GetBySystemName(region);
        }

        public AmazonS3Client GetS3Client(
            string accessKey,
            string secretKey,
            string region)
        {
            AmazonS3Client amazonS3Client = new AmazonS3Client(
                accessKey,
                secretKey,
                GetEndPointAssociationToRegion(region)
                );

            return amazonS3Client;

        }

        private async Task<S3Bucket> GetBucket(
            AmazonS3Client s3Client,
            string bucketName
            )
        {
            var bucketListResponse = await s3Client.ListBucketsAsync();
            return bucketListResponse.Buckets.FirstOrDefault(a => a.BucketName == bucketName);
        }

        private void CreateBucket(
            AmazonS3Client s3Client,
            string region,
            string bucketName)
        {
            if (GetBucket(s3Client, bucketName) == null)
            {
                PutBucketRequest bucketRequest = new PutBucketRequest()
                {
                    BucketName = bucketName,
                    BucketRegion = region
                };

                bucketRequest.BucketName = bucketName;
                
                s3Client.PutBucketAsync(bucketRequest);
            }
        }

       

    }
}
