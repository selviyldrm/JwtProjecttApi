using JwtOrnekProje.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtOrnekProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult GetToken()
        {
            return Created("", new BuildToken().CreateToken());
        }
        
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult CustomerList()
        {
            return Ok("Müşteri Listesine Eriştiniz.");
        }
    }
}
