using System.Linq;
using System.Collections.Generic;
using Api.Services.Core.PlutoRover.Services.PlutoRover.Model;

namespace Api.Services.Core.PlutoRover.Services.PlutoRover.Validations
{
    public class Validator : IValidator
    {
        private readonly IEnumerable<IValidate> _validations;

        public Validator(IEnumerable<IValidate> validations)
        {
            _validations = validations;
        }

        public List<string> Run(Position position)
        {
            var errors = _validations
             .Where(v => !v.IsValid(position))
             .Select(p => p.Message)
             .ToList();

            return errors ?? new List<string>();
        }
    }
}