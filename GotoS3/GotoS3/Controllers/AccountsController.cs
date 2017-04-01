using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.Controllers
{
    [Route("api/regions")]
    public class AccountsController : Controller
    {
        [HttpGet("{regionId}/accounts")]
        public IActionResult GetAccounts(int regionId)
        {
            var region = RegionDataStore.Current.regions.FirstOrDefault(r => r.Id == regionId);
            if (region == null)
            {
                return NotFound();
            }
            return Ok(region.accounts);
        }

        [HttpGet("{regionId}/accounts/{id}")]
        public IActionResult GetAccount(int regionId, int id)
        {
            var region = RegionDataStore.Current.regions.FirstOrDefault(r => r.Id == regionId);
            if (region == null)
            {
                return NotFound();
            }
            var accountToReturn = region.accounts.FirstOrDefault(a => a.Id == id);
            if (accountToReturn == null)
            {
                return NotFound();
            }
            return Ok(accountToReturn);
        }
    }
}
