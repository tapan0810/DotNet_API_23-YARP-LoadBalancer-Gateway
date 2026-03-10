using AutoMapper;
using DotNet_API_23.Entities.Dtos;
using DotNet_API_23.Entities.Models;

namespace DotNet_API_23.Mapping
{
    public class HotelMappingProfile : Profile
    {
       public HotelMappingProfile() {

            CreateMap<Hotel, GetAllHotelsDto>();

            CreateMap<Hotel, GetHotelyIdDto>();

            CreateMap<CreateHotelDto, Hotel>();

            CreateMap<UpdateHotelDto, Hotel>();
        }
    }
}
