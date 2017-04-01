using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.Models
{
    public class bucketDto
    {
        public string Name { get; set; }
        public ICollection<itemDto> items { get; set; } = new List<itemDto>();
    }
}
