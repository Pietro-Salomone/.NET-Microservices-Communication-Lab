using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            CreateMap<Platform, PlatformReadDto>()
                .ReverseMap();
            CreateMap<PlatformCreateDto, Platform>()
                .ForMember(s => s.Id, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<PlatformReadDto, PlatformPublishedDto>();
            CreateMap<Platform, GrpcPlatformModel>()
                .ForMember(d => d.PlatformId, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(d => d.Publisher, opt => opt.MapFrom(s => s.Publisher));
        }
    }
}