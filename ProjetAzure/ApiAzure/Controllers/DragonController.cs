using ApiAzure.Data;
using ApiAzure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DragonController : ControllerBase
    {
        private readonly FakeDragonDb _fakeDragonDb;

        public DragonController(FakeDragonDb fakeDragonDb)
        {
            _fakeDragonDb = fakeDragonDb;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_fakeDragonDb.ObtenirTous());
        }
    }
}
