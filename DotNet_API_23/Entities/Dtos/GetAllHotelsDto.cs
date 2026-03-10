using System.ComponentModel.DataAnnotations;

namespace DotNet_API_23.Entities.Dtos
{
    public class GetAllHotelsDto
    {
        public string HotelName { get; set; } = string.Empty;
        public string HotelAddress { get; set; } = string.Empty;
        public string HotelCity { get; set; } = string.Empty;
        [Phone]
        public string Phone { get; set; } = string.Empty;
    }
}
