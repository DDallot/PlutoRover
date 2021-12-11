using System;
using AutoMapper;
using System.Threading.Tasks;
using Api.Contracts.Core.PlutoRover.PlutoRover.v1;
using Api.Services.Core.PlutoRover.Dal.PlutoRover;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Dtos;
using Api.Contracts.Core.PlutoRover.Common;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Helpers;

namespace Api.Services.Core.PlutoRover.Services.PlutoRover
{
    public class PlutoRoverService : IPlutoRover
    {
        private readonly ICommandHandler _commandHandler;
        private readonly IPlutoRoverDal _plutoRoverDal;
        private readonly IMapper _mapper;

        public PlutoRoverService(ICommandHandler commandHandler, IPlutoRoverDal plutoRoverDal, IMapper mapper)
        {
            _commandHandler = commandHandler ?? throw new ArgumentNullException(nameof(commandHandler));
            _plutoRoverDal = plutoRoverDal ?? throw new ArgumentNullException(nameof(plutoRoverDal));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ItemResult<string>> GetAsync(int roverId)
        {
            var rover = await _plutoRoverDal.GetRoverAsync(roverId);
            var roverDto = _mapper.Map<RoverDto>(rover);

            return new ItemResult<string>()
            {
                Item = ConvertRoverDto(roverDto),
                HasError = roverDto.HasErrors,
                Errors = roverDto.Errors
            };
        }

        public async Task<ItemResult<string>> ExecuteComandsAsync(int roverId, PlutoRoverRequest request)
        {
            var rover = await _plutoRoverDal.GetRoverAsync(roverId);
            var roverDto = _mapper.Map<RoverDto>(rover);

            roverDto = _commandHandler.Process(roverDto, request.Command);

            return new ItemResult<string>()
            {
                Item = ConvertRoverDto(roverDto),
                HasError = roverDto.HasErrors,
                Errors = roverDto.Errors
            };
        }

        private static string ConvertRoverDto(RoverDto roverDto) 
            => $"{roverDto.Position.X}, {roverDto.Position.Y}, {HeadingHelper.ConvertToChar(roverDto.Position.Heading)}";
    }
}
