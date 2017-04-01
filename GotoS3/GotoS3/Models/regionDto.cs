using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.Models
{
    public class regionDto
    {
        public int Id { get; set; }
        public string name { get; set; }
        public ICollection<accountDto> accounts { get; set; } = new List<accountDto>();
    }
}
