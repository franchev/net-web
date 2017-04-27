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
    [Route("api/accounts")]
    public class AccountController : Controller
    {

        private IGotoS3Repository _gotoS3Repository;

        public AccountController(IGotoS3Repository gotos3Repository)
        {
            _gotoS3Repository = gotos3Repository;
        }

        /// <summary>
        /// Get a list of AWS S3 Accounts
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetAccounts")]
        public IActionResult GetAccounts()
        {
            var accounts = _gotoS3Repository.GetAccounts();
            if (accounts == null)
            {
                return NotFound();
            }
            return Ok(accounts);
        }

        /// <summary>
        /// Get a Specific Account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name ="GetAccount")]
        public IActionResult GetAccount(int id)
        {
            var account = _gotoS3Repository.GetAccount(id);
            if (account == null)
            {
                return NotFound();
            }
            return Ok(account);
        }

        /// <summary>
        /// Add an Account
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        [HttpPost(Name ="AddAccount")]
        public IActionResult AddAccount(
            [FromBody] accountForCreationDto account)
        {
            if (account == null)
            {
                return BadRequest();
            }
            var accountEntity = Mapper.Map<Account>(account);
            _gotoS3Repository.AddAccount(accountEntity);

            if (!_gotoS3Repository.Save())
            {
                throw new Exception("Creating an account failed on save.");
            }

            var accountToReturn = Mapper.Map<accountDto>(accountEntity);
            return CreatedAtRoute("GetAccount",
                new { id = accountToReturn.Id },
                accountToReturn);
        }
    }
}
