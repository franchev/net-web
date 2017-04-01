using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.Controllers
{
    [Route("api/encrypts")]
    public class EncryptController: Controller
    {
        [HttpGet("keys")]
        public IActionResult GetEncrypts()
        {
            return Ok(encryptDataStore.encryptCurrent.encryptors);
        }
        
        [HttpGet("keys/{id}")]
        public IActionResult GetEncrypt(int id)
        {
            var encryptorResult = encryptDataStore.encryptCurrent.encryptors.FirstOrDefault(e => e.Id == id);
            if (encryptorResult == null)
            {
                return NotFound();
            }
            return Ok(encryptorResult);
        }
    }
}
