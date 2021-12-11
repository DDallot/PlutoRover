using Api.Services.Core.PlutoRover.Services.PlutoRover.Helpers;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Model;

namespace Api.Services.Core.PlutoRover.Services.PlutoRover.Commands
{
    public class RightCommand : ICommand
    {
        public char Key => Constants.Right;

        public Position ExecuteOn(Position currentPosition)
        {
            var newPosition = currentPosition.Clone();
            newPosition.Heading = HeadingHelper.FixedValue(newPosition.Heading + 90);

            return newPosition;
        }
    }
}
