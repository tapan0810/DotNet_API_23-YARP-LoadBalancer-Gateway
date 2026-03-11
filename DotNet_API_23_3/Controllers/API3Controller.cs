using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_API_23_3.Controllers
{
    [Route("api/hotel")]
    [ApiController]
    public class API3Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHotels()
        {
            return Ok("Response from Hotel Service 3");
        }
    }
}
