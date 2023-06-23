using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public IActionResult GetLocationList()
        {
            var values = _locationService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetLocationById(int id)
        {
            var values = _locationService.TGetById(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddLocation(Location location)
        {
            _locationService.TCreate(location);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateLocation(Location location)
        {
            _locationService.TUpdate(location);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteLocation(int id)
        {
            var values = _locationService.TGetById(id);
            _locationService.TDelete(values);
            return Ok();
        }
    }
}
