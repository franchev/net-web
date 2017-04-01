using GotoS3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.Controllers
{
    //[Route("api/[controller")]
    [Route("api/regions")]
    public class BucketsController : Controller
    {
        /// <summary>
        /// Method to get a list of buckets in S3 for an account in a specific region
        /// </summary>
        /// <returns></returns>
        [HttpGet("{regionId}/accounts/{accountId}/buckets")]
        public IActionResult GetBuckets(int regionId, int accountId)
        {
            var region = RegionDataStore.Current.regions.FirstOrDefault(r => r.Id == regionId);
            if (region == null)
            {
                return NotFound();
            }
            var account = region.accounts.FirstOrDefault(a => a.Id == accountId);
            if (account == null)
            {
                return NotFound();
            }
            // here needs to return all the buckets associated to this account
            return Ok(account.buckets);
        }

        /// <summary>
        /// Method to get a list of contents from an S3 bucket in a specific region
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="bucketName"></param>
        /// <param name="dataRetrieve"></param>
        /// <returns></returns>
        [HttpGet("{regionId}/accounts/{accountId}/buckets/{bucketName}")]
        public IActionResult GetContentFromBucket(int regionId, int accountId, string bucketName)
        {
            var region = RegionDataStore.Current.regions.FirstOrDefault(r => r.Id == regionId);
            if (region == null)
            {
                return NotFound();
            }
            var account = region.accounts.FirstOrDefault(a => a.Id == accountId);
            if (account == null)
            {
                return NotFound();
            }
            var bucket = account.buckets.FirstOrDefault(a => a.Name == bucketName);
            if (bucket == null)
            {
                return NotFound();
            }
            return Ok(bucket.items);

        }

        /// <summary>
        /// Method Download a list of items from an S3 bucket
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="bucketName"></param>
        /// <param name="dataRetrieve"></param>
        /// <returns></returns>
        [HttpGet("{regionId}/accounts/{accountId}/buckets/{bucketName}")]
        public IActionResult DownloadFromBucket(int regionId, int accountId, string bucketName, List<dataDto> content)
        {
            // THIS NEEDS FURTHER IMPLEMENTATION
            var region = RegionDataStore.Current.regions.FirstOrDefault(r => r.Id == regionId);
            if (region == null)
            {
                return NotFound();
            }
            var account = region.accounts.FirstOrDefault(a => a.Id == accountId);
            if (account == null)
            {
                return NotFound();
            }
            var bucket = account.buckets.FirstOrDefault(a => a.Name == bucketName);
            if (bucket == null)
            {
                return NotFound();
            }
            return Ok(bucket.items);
        }

        /// <summary>
        /// Method to create an S3 bucket
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="bucketEntry"></param>
        /// <returns></returns>
        //[HttpPost("{regionId}/accounts/{accountId}/buckets")]
        //public IActionResult AddBucket(int regionId, int accountId, bucketDto bucketEntry)
        //{
        //    var region = RegionDataStore.Current.regions.FirstOrDefault(r => r.Id == regionId);
        //    if (region == null)
        //    {
        //        return NotFound();
        //    }
        //    var account = region.accounts.FirstOrDefault(a => a.Id == accountId);
        //    if (account == null)
        //    {
        //        return NotFound();
        //    }
        //    //IMPLEMENTATION FOR CREATING A BUCKET MISSING
        //}

        /// <summary>
        /// Method to upload data to an S3 bucket
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="bucketName"></param>
        /// <param name="dataEntry"></param>
        /// <returns></returns>
        //[HttpPost("{regionId}/accounts/{accountId}/buckets")]
        //public IActionResult UploadToBucket(int regionId, int accountId, string bucketName, dataDto dataEntry)
        //{
        //    var region = RegionDataStore.Current.regions.FirstOrDefault(r => r.Id == regionId);
        //    if (region == null)
        //    {
        //        return NotFound();
        //    }
        //    var account = region.accounts.FirstOrDefault(a => a.Id == accountId);
        //    if (account == null)
        //    {
        //        return NotFound();
        //    }
        //    //IMPLEMENTATION FOR UPLOADING A BUCKET MISSING
        //}

        /// <summary>
        /// Method to delete an S3 bucket
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="bucketEntry"></param>
        /// <returns></returns>
        //[HttpDelete("{regionId}/accounts/{accountId}/buckets")]
        //public IActionResult DeleteBucket(int regionId, int accountId, bucketDto bucketEntry)
        //{
        //    var region = RegionDataStore.Current.regions.FirstOrDefault(r => r.Id == regionId);
        //    if (region == null)
        //    {
        //        return NotFound();
        //    }
        //    var account = region.accounts.FirstOrDefault(a => a.Id == accountId);
        //    if (account == null)
        //    {
        //        return NotFound();
        //    }
        //    //IMPLEMENTATION FOR DELETING A BUCKET MISSING
        //}

        /// <summary>
        /// Method to delete an item from an S3 bucket
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="bucketName"></param>
        /// <returns></returns>
        //[HttpDelete("{accountId/buckets/{bucketName}/{key}")]
        //public IActionResult DeleteFromBucket(int regionId, int accountId, string bucketName, string key)
        //{
        //    var region = RegionDataStore.Current.regions.FirstOrDefault(r => r.Id == regionId);
        //    if (region == null)
        //    {
        //        return NotFound();
        //    }
        //    var account = region.accounts.FirstOrDefault(a => a.Id == accountId);
        //    if (account == null)
        //    {
        //        return NotFound();
        //    }
        //    //IMPLEMENTATION FOR DELETING FROM A BUCKET MISSING
        //}



    }
}
