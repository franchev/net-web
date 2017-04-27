using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.API.Entities
{
    public class Account
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string username { get; set; }

        [MaxLength(100)]
        public string AccessKey { get; set; }

        [Required]
        [MaxLength(100)]
        public string SecretKey { get; set; }

    }
}
