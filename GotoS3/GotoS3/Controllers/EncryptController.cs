using AutoMapper;
using GotoS3.API.Entities;
using GotoS3.API.Models;
using GotoS3.Models;
using GotoS3.Services;
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
        private IGotoS3Repository _gotoS3Repository;

        public EncryptController(IGotoS3Repository gotos3Repository)
        {
            _gotoS3Repository = gotos3Repository;
        }

        [HttpGet(Name ="GetEncryptors")]
        public IActionResult GetKeys()
        {
            var encryptor = _gotoS3Repository.GetEncryptors();
            if (encryptor == null)
            {
                return NotFound();
            }
            return Ok(encryptor);
        }
        
        [HttpGet("{id}", Name ="GetEncryptor")]
        public IActionResult GetEncrypt(int id)
        {
            var encryptor = _gotoS3Repository.GetEncryptor(id);
            if (encryptor == null)
            {
                return NotFound();
            }
            return Ok(encryptor);
        }

        /// <summary>
        /// Add an encryptor
        /// </summary>
        /// <param name="encryptor"></param>
        /// <returns></returns>
        [HttpPost(Name = "AddEncryptor")]
        public IActionResult AddEncryptor(
            [FromBody] EncryptorForCreationDto encryptor)
        {
            if (encryptor == null)
            {
                return BadRequest();
            }
            var encryptorEntity = Mapper.Map<Encryptor>(encryptor);
            _gotoS3Repository.AddEncryptor(encryptorEntity);

            if (!_gotoS3Repository.Save())
            {
                throw new Exception("Creating an encryptor failed on save.");
            }

            var encryptToReturn = Mapper.Map<encryptorDto>(encryptorEntity);
            return CreatedAtRoute("GetEncryptor",
                new { id = encryptToReturn.Id },
                encryptToReturn);
        }
    }
}
