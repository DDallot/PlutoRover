using Api.Services.Core.PlutoRover.Dal.PlutoRover;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Dtos;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Model;
using AutoMapper;

namespace Api.Services.Core.PlutoRover.Services.PlutoRover.Mapping
{
    public class PlutoRoverProfiles : Profile
    {
        public PlutoRoverProfiles()
        {
            CreateMap<Rover, RoverDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Position, opt => opt.MapFrom(src => new Position(src.X, src.Y, src.Heading)));
        }
    }
}