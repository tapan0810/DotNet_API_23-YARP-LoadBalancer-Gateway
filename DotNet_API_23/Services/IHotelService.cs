using DotNet_API_23.Entities.Dtos;

namespace DotNet_API_23.Services
{
    public interface IHotelService
    {
        public Task<List<GetAllHotelsDto>> GetAllHotels(int pageNumber, int pageSize);
        public Task<GetHotelyIdDto> GetHotelyId(int id);
        public Task<GetHotelyIdDto> CreateHotel(CreateHotelDto dto);
        public Task<bool> UpdateHotel(int id,UpdateHotelDto dto);
        public Task<bool> DeleteHotel(int id);
    }
}
