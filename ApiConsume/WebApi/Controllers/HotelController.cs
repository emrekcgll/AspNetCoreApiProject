using BusinessLayer.Abstract;
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
        public IActionResult AddHotel(Hotel hotel)
        {
            _hotelService.TCreate(hotel);
            return Ok();
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
