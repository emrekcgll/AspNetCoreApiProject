using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }


        [HttpGet]
        public IActionResult GetHotelList()
        {
            var values = _hotelService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetHotelById(int id)
        {
            var values = _hotelService.TGetById(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> AddHotel(Hotel hotel)
        {
            using (var c = new Context())
            {
                var location = c.Locations.FirstOrDefault(l => l.LocationID == hotel.LocationID);
                if (location != null)
                {
                    hotel.Location = location;
                    await c.AddAsync(hotel);
                    await c.SaveChangesAsync();

                    return Ok();
                }
                else
                {
                    return BadRequest("Lokasyon mevcut değil!");
                }
            }
        }

        [HttpPut]
        public IActionResult UpdateHotel(Hotel hotel)
        {
            _hotelService.TUpdate(hotel);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteHotel(int id)
        {
            var values = _hotelService.TGetById(id);
            _hotelService.TDelete(values);
            return Ok();
        }
    }
}
