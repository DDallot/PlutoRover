using Api.Services.Core.PlutoRover.Configuration;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Model;

namespace Api.Services.Core.PlutoRover.Services.PlutoRover.Validations
{
    public class ValidateEdges : IValidate
    {
        private readonly GridConfig _grid;
        private const string _message = "Out of the grid";

        public ValidateEdges(GridConfig grid)
        {
            _grid = grid;
        }

        public string Message => _message;
        public bool IsValid(Position position)
        {
            return position.X <= _grid.MaxX && position.X >= _grid.MinX &&
                   position.Y <= _grid.MaxY && position.Y >= _grid.MinY;
        }
    }
}
