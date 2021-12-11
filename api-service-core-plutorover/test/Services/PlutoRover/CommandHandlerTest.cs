using Xunit;
using FluentAssertions;
using Api.Services.Core.PlutoRover.Services.PlutoRover;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Dtos;
using System.Collections.Generic;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Commands;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Validations;
using Api.Services.Core.PlutoRover.Configuration;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Model;

namespace Api.Services.Core.PlutoRover.UnitTests.Services.PlutoRover
{
    public class CommandHandlerTest
    {
        private readonly CommandBuilder _commandBuilder;

        public CommandHandlerTest()
        {
            _commandBuilder = new CommandBuilder(new List<ICommand>
            {
                new ForwardCommand(),
                new RightCommand(),
                new BackwardCommand(),
                new LeftCommand(),
            });
        }

        [Fact]
        public void Test_Success()
        {
            var validator = new Validator(new List<IValidate>
            {
                new ValidateEdges(new GridConfig{ MaxX = 100, MaxY= 100, MinX = 0, MinY = 0 })
            });
            var commandHandler = new CommandHandler(_commandBuilder, validator);
            var roverDto = new RoverDto { Id = 23, Position = new Position(0,0,0)};
            var commands = "FFRFF";
            
            var result = commandHandler.Process(roverDto, commands);

            result.Id.Should().Be(23);
            result.Position.X.Should().Be(2);
            result.Position.Y.Should().Be(2);
            result.Position.Heading.Should().Be(90);
        }

        [Fact]
        public void Test_Collision()
        {
            var validator = new Validator(new List<IValidate>
            {
                new ValidateEdges(new GridConfig{MaxX=100, MaxY= 100, MinX = 0, MinY = 0})
            });
            var commandHandler = new CommandHandler(_commandBuilder, validator);
            var roverDto = new RoverDto { Id = 23, Position = new Position(0, 0, 0) };
            var commands = "FFRFFRFFF";

            var result = commandHandler.Process(roverDto, commands);

            result.Id.Should().Be(23);
            result.HasErrors.Should().Be(true);
            result.Errors.Should().NotBeEmpty()
                .And.HaveCount(1)
                .And.ContainInOrder(new[] { "Out of the grid" })
                .And.ContainItemsAssignableTo<string>();
        }
    }
}
