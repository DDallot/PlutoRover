using Api.Services.Core.PlutoRover.Services.PlutoRover.Model;

namespace Api.Services.Core.PlutoRover.Services.PlutoRover.Validations
{
    public interface IValidate
    {
        public string Message { get; }
        bool IsValid(Position position);
    }
}
