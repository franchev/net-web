using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.Controllers
{
    [Route("api/regions")]
    public class RegionsController: Controller
    {
        [HttpGet("")]
        public IActionResult GetRegions()
        {
            return Ok(RegionDataStore.Current.regions);
        }

        [HttpGet("{id}")]
        public IActionResult GetRegion(int id)
        {
            var regionToReturn = RegionDataStore.Current.regions.FirstOrDefault(r => r.Id == id);

            if (regionToReturn == null)
            {
                return NotFound();
            }
            return Ok(regionToReturn);
        }
    }
}
