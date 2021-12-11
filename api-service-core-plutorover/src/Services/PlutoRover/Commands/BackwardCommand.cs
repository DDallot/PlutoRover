using Api.Services.Core.PlutoRover.Services.PlutoRover.Helpers;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Model;

namespace Api.Services.Core.PlutoRover.Services.PlutoRover.Commands
{
    public class BackwardCommand : ICommand
    {
        public char Key => Constants.Backward;

        public Position ExecuteOn(Position currentPosition)
        {
            var newPosition = currentPosition.Clone();

            if (currentPosition.Heading == 0)
            {
                newPosition.Y -= 1;
            }else if (currentPosition.Heading == 90)
            {
                newPosition.X -= 1;
            }
            else if (currentPosition.Heading == 180)
            {
                newPosition.Y += 1;
            }
            else if (currentPosition.Heading == 270)
            {
                newPosition.X += 1;
            }

            return newPosition;
        }
    }
}
