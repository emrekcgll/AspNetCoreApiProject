using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHotelList()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetHotelById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddHotel()
        {
            return Ok();
        }
    }
}
