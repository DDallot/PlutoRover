using System;
using System.Linq;
using System.Collections.Generic;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Commands;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Validations;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Dtos;

namespace Api.Services.Core.PlutoRover.Services.PlutoRover
{
    public class CommandHandler : ICommandHandler
    {
        private readonly Dictionary<char, ICommand> _commands;
        private readonly IValidator _validator;

        public CommandHandler(CommandBuilder commandBuilder, IValidator validator)
        {
            _commands = commandBuilder?.Commands ?? throw new ArgumentNullException(nameof(commandBuilder));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }
        public RoverDto Process(RoverDto roverDto, string commands)
        {
            foreach (var cmd in commands)
            {
                var newPosition = _commands[cmd].ExecuteOn(roverDto.Position);
                var errors = _validator.Run(newPosition);

                if (errors.Any())
                {
                    roverDto.HasErrors = true;
                    roverDto.Errors = errors;
                }
                else
                {
                    roverDto.Position = newPosition;
                }
            }
            return roverDto;
        }
    }
}
