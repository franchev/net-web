using GotoS3.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.Controllers
{
    [Route("api/regions")]
    public class RegionsController : Controller
    {
        private IGotoS3Repository _gotoS3Repository;

        public RegionsController(IGotoS3Repository gotos3Repository)
        {
            _gotoS3Repository = gotos3Repository;
        }

        [HttpGet("")]
        public IActionResult GetRegions()
        {
            return Ok(_gotoS3Repository.GetRegions());
        }

    }
}
