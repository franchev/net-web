using GotoS3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3
{
    public class encryptDataStore
    {
        public List<encryptDto> encryptors { get; set; }
        public static encryptDataStore encryptCurrent { get; } = new encryptDataStore();

        public encryptDataStore()
        {
            encryptors = new List<encryptDto>()
            {
                new encryptDto()
                {
                    Id = 1,
                    name = "onsite",
                    value = "onsite"
                },
                new encryptDto()
                {
                    Id = 2,
                    name = "cloud",
                    value = "cloud"
                },
            };
        }
    }
}
