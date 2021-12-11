using Api.Services.Core.PlutoRover.Services.PlutoRover.Model;
using System.Collections.Generic;

namespace Api.Services.Core.PlutoRover.Services.PlutoRover.Dtos
{
    public class RoverDto
    {
        public int Id { get; set; }
        public Position Position { get; set; }

        public bool HasErrors { get; set; }
        public List<string> Errors { get; set; }
    }
}
