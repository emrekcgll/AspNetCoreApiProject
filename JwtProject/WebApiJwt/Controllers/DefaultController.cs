using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult CreateToken()
        {
            return Ok(new CreateToken().TokenCreate());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult TestToken()
        {
            return Ok("Token onaylandı.");
        }


        [HttpGet("[action]")]
        public IActionResult CreateAdminToken()
        {
            return Ok(new CreateToken().TokenCreateForAdmin());
        }

        [Authorize(Roles = "Admin, Visitor")]
        [HttpGet("[action]")]
        public IActionResult TestAdminToken()
        {
            return Ok("Admin token başarılı.");
        }
    }
}
