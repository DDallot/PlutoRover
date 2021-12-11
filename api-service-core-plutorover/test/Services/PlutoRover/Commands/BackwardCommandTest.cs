using Xunit;
using FluentAssertions;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Commands;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Model;


namespace Api.Services.Core.PlutoRover.UnitTests.Services.PlutoRover
{
    public class BackwardCommandTest
    {
        [Fact]
        public void Test_0_0_0()
        {
            var backwardCommand = new BackwardCommand();
            var currentPosition = new Position(0,0,0);

            var resultPosition = backwardCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(0);
            resultPosition.Y.Should().Be(-1);
            resultPosition.Heading.Should().Be(0);
        }

        [Fact]
        public void Test_0_0_90()
        {
            var backwardCommand = new BackwardCommand();
            var currentPosition = new Position(0, 0, 90);

            var resultPosition = backwardCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(-1);
            resultPosition.Y.Should().Be(0);
            resultPosition.Heading.Should().Be(90);
        }

        [Fact]
        public void Test_0_0_180()
        {
            var backwardCommand = new BackwardCommand();
            var currentPosition = new Position(0, 0, 180);

            var resultPosition = backwardCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(0);
            resultPosition.Y.Should().Be(1);
            resultPosition.Heading.Should().Be(180);
        }


        [Fact]
        public void Test_0_0_270()
        {
            var backwardCommand = new BackwardCommand();
            var currentPosition = new Position(0, 0, 270);

            var resultPosition = backwardCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(1);
            resultPosition.Y.Should().Be(0);
            resultPosition.Heading.Should().Be(270);
        }

        [Fact]
        public void Test_Negatives_1_1_0()
        {
            var backwardCommand = new BackwardCommand();
            var currentPosition = new Position(-1,-1,0);

            var resultPosition = backwardCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(-1);
            resultPosition.Y.Should().Be(-2);
            resultPosition.Heading.Should().Be(0);
        }

        [Fact]
        public void Test_Negatives_1_1_90()
        {
            var backwardCommand = new BackwardCommand();
            var currentPosition = new Position(-1, -1, 90);

            var resultPosition = backwardCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(-2);
            resultPosition.Y.Should().Be(-1);
            resultPosition.Heading.Should().Be(90);
        }

        [Fact]
        public void Test_Negatives_1_1_180()
        {
            var backwardCommand = new BackwardCommand();
            var currentPosition = new Position(-1, -1, 180);

            var resultPosition = backwardCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(-1);
            resultPosition.Y.Should().Be(0);
            resultPosition.Heading.Should().Be(180);
        }


        [Fact]
        public void Test_Negatives_1_1_270()
        {
            var backwardCommand = new BackwardCommand();
            var currentPosition = new Position(-1, -1, 270);

            var resultPosition = backwardCommand.ExecuteOn(currentPosition);

            resultPosition.X.Should().Be(0);
            resultPosition.Y.Should().Be(-1);
            resultPosition.Heading.Should().Be(270);
        }
    }
}