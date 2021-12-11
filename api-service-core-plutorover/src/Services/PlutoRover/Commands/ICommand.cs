using Api.Services.Core.PlutoRover.Services.PlutoRover.Model;

namespace Api.Services.Core.PlutoRover.Services.PlutoRover.Commands
{
    public interface ICommand
    {
        char Key { get; }
        public Position ExecuteOn(Position currentPosition);
    }
}
