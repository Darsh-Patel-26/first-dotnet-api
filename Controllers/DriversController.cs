using DriversApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DriversApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        public ApplicationDb _db { get; set; }
        public DriversController(ApplicationDb db) { _db = db; }

        [HttpGet]
        public IActionResult GetDriver()
        {
            var drivers = _db.Drivers.ToList();
            return Ok(drivers);
        }

        [HttpPost]
        public IActionResult PostDriver(DriverDto d)
        {
            if (d == null)
            {
                return BadRequest();
            }
            
            Driver dr = new Driver()
            {
                Id = Guid.NewGuid(),
                Name = d.Name,
                DriverNo = d.DriverNo,
                Wdc = d.Wdc,
                Races = d.Races,
                Wins = d.Wins,
                Logo = d.Logo,
                Photo = d.Photo,
                Team = d.Team,
            };
            _db.Drivers.Add(dr);
            _db.SaveChanges();
            return Ok(dr);
        }
    }
}
