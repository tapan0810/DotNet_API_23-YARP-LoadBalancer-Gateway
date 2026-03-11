
using DotNet_API_23.Entities.Dtos;
using DotNet_API_23.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_API_23.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController(IHotelService _service) : ControllerBase
    {
        [HttpGet("GetAllHotels")]
        public async Task<ActionResult<GetAllHotelsDto>> GetAllHotels(int pageNumber,int pageSize)
        {
            var hotels = await _service.GetAllHotels(pageNumber,pageSize);

            if (hotels is null || hotels.Count == 0)
                return BadRequest("No Hotel Found !");

            return Ok(hotels);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GetHotelyIdDto>> GetHotelById(int id)
        {
            var hotel = await _service.GetHotelyId(id);

            if (hotel is null)
                return BadRequest("No Hotel Found with this Id");
            return Ok(hotel);
        }

        [HttpPost("CreateHotel")]
        public async Task<ActionResult<GetHotelyIdDto?>> CreateHotel(CreateHotelDto createHotel)
        {
            var hotel = await _service.CreateHotel(createHotel);

            if (hotel is null) return BadRequest("Invalid Hotel");

            return CreatedAtAction(nameof(GetHotelById), new {id=hotel.Id}, hotel);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<bool>> DeleteHotel(int id)
        {
            var hotel = await _service.DeleteHotel(id);

            if (!hotel) return BadRequest("No Hotel Found with this Id");
            return Ok(hotel);
        }
    }
}
