using GotoS3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3
{
    public class RegionDataStore
    {
        public List<regionDto> regions { get; set; }
        public static RegionDataStore Current { get; } = new RegionDataStore();

        public RegionDataStore()
        {
            regions = new List<regionDto>()
            {
                new regionDto()
                {
                    Id = 1,
                    name = "us-east-1",
                    accounts = new List<accountDto>()
                    {
                        new accountDto()
                        {
                            Id = 1,
                            subscription = "lmi",
                            username = "test",
                            accessKey = "test",
                            secretKey = "test",
                            buckets = new List<bucketDto>()
                            {
                                new bucketDto()
                                {
                                    Name = "backup",
                                    items = new List<itemDto>()
                                    {
                                        new itemDto()
                                        {
                                            name = "key1",
                                            size = 12
                                        }
                                    }
                                }
                            }
                        },
                        new accountDto()
                        {
                            Id = 2,
                            subscription = "onprem",
                            username = "test",
                            accessKey = "test",
                            secretKey = "test",
                             buckets = new List<bucketDto>()
                            {
                                new bucketDto()
                                {
                                    Name = "backup2",
                                    items = new List<itemDto>()
                                    {
                                        new itemDto()
                                        {
                                            name = "key1",
                                            size = 12
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new regionDto()
                {
                    Id = 2,
                    name = "us-west-1",
                    accounts = new List<accountDto>()
                    {
                        new accountDto()
                        {
                            Id = 1,
                            subscription = "west-coast",
                            username = "test",
                            accessKey = "test",
                            secretKey = "test",
                             buckets = new List<bucketDto>()
                            {
                                new bucketDto()
                                {
                                    Name = "west-backup",
                                    items = new List<itemDto>()
                                    {
                                        new itemDto()
                                        {
                                            name = "key1",
                                            size = 12
                                        }
                                    }
                                }
                            }
                        },
                        new accountDto()
                        {
                            Id = 2,
                            subscription = "west-coast2",
                            username = "test",
                            accessKey = "test",
                            secretKey = "test",
                             buckets = new List<bucketDto>()
                            {
                                new bucketDto()
                                {
                                    Name = "west-backup2",
                                    items = new List<itemDto>()
                                    {
                                        new itemDto()
                                        {
                                            name = "key1",
                                            size = 12
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
