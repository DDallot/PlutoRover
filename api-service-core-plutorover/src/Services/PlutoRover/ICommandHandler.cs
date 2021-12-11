using Api.Services.Core.PlutoRover.Services.PlutoRover.Dtos;

namespace Api.Services.Core.PlutoRover.Services
{
    public interface ICommandHandler
    {
        RoverDto Process(RoverDto roverDto, string commands);
    }
}
