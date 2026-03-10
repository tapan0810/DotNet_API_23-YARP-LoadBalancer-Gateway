using System.ComponentModel.DataAnnotations;

namespace DotNet_API_23.Entities.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string HotelName { get; set; } = string.Empty;
        public string HotelAddress { get; set; } = string.Empty;
        public string HotelCity { get; set;} = string.Empty;
        [Phone]
        public string Phone { get; set; } = string.Empty;
    }
}
