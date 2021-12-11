using Api.Services.Core.PlutoRover.Services.PlutoRover.Model;
using System.Collections.Generic;

namespace Api.Services.Core.PlutoRover.Services.PlutoRover.Validations
{
    public interface IValidator
    {
        List<string> Run(Position position);
    }
}
