using AutoMapper;
using DotNet_API_23.Data;
using DotNet_API_23.Entities.Dtos;
using DotNet_API_23.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_API_23.Services
{
    public class HotelService(IMapper _mapper ,HotelDbContext _context) : IHotelService
    {
        public async Task<GetHotelyIdDto> CreateHotel(CreateHotelDto dto)
        {
            var hotel = _mapper.Map<Hotel>(dto);

            if (hotel is null) return null;

            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
            
            return _mapper.Map<GetHotelyIdDto>(hotel);
        }

        public async Task<bool> DeleteHotel(int id)
        {
            var hotel = await _context.Hotels.FirstOrDefaultAsync(h => h.Id == id);

            if (hotel is null) return false;

            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<GetAllHotelsDto>> GetAllHotels(int pageNumber,int pageSize)
        {
            var hotels =await _context.Hotels
                        .Skip((pageNumber-1)*pageSize)
                        .Take(pageSize)
                        .ToListAsync();

            return _mapper.Map<List<GetAllHotelsDto>>(hotels);
        }

        public async Task<GetHotelyIdDto?> GetHotelyId(int id)
        {
            var hotel = await _context.Hotels.FirstOrDefaultAsync(x => x.Id == id);

            if (hotel is null) return null;
            
            return _mapper.Map<GetHotelyIdDto?>(hotel);
        }

        public async Task<bool> UpdateHotel(int id, UpdateHotelDto dto)
        {
            var hotel = await _context.Hotels.FirstOrDefaultAsync(_ => _.Id == id);
            if (hotel is null) return false;

            _mapper.Map( hotel,dto);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
