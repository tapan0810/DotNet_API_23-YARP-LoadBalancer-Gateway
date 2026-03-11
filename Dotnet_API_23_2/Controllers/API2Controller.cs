using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_API_23_2.Controllers
{
    [Route("api/hotel")]
    [ApiController]
    public class API2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHotels()
        {
            return Ok("Response from Hotel Service 2");
        }
    }
}

