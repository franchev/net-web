using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.Models
{
    public class accountDto
    {
        public int Id { get; set; }
        public string subscription { get; set; }
        public string username { get; set; }
        public string accessKey { get; set; }
        public string secretKey { get; set; }
        public ICollection<bucketDto> buckets { get; set; } = new List<bucketDto>();
    }
}
