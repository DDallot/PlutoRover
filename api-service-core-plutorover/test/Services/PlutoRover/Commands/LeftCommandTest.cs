using Xunit;
using FluentAssertions;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Commands;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Model;

namespace Api.Services.Core.PlutoRover.UnitTests.Services.PlutoRover.Commands
{
    public class LeftCommandTest
    {
        [Fact]
        public void Test_0_0_0()
        {
            var leftCommand = new LeftCommand();
            var currentPosition = new Position(0, 0, 0);

            var resultPosition = leftCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(0);
            resultPosition.Y.Should().Be(0);
            resultPosition.Heading.Should().Be(270);
        }

        [Fact]
        public void Test_0_0_90()
        {
            var leftCommand = new LeftCommand();
            var currentPosition = new Position(0, 0, 90);

            var resultPosition = leftCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(0);
            resultPosition.Y.Should().Be(0);
            resultPosition.Heading.Should().Be(0);
        }

        [Fact]
        public void Test_0_0_180()
        {
            var leftCommand = new LeftCommand();
            var currentPosition = new Position(0, 0, 180);

            var resultPosition = leftCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(0);
            resultPosition.Y.Should().Be(0);
            resultPosition.Heading.Should().Be(90);
        }

        [Fact]
        public void Test_0_0_270()
        {
            var leftCommand = new LeftCommand();
            var currentPosition = new Position(0, 0, 270);

            var resultPosition = leftCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(0);
            resultPosition.Y.Should().Be(0);
            resultPosition.Heading.Should().Be(180);
        }

        [Fact]
        public void Test_0_0_360()
        {
            var leftCommand = new LeftCommand();
            var currentPosition = new Position(0, 0, 360);

            var resultPosition = leftCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(0);
            resultPosition.Y.Should().Be(0);
            resultPosition.Heading.Should().Be(270);
        }
    }
}
