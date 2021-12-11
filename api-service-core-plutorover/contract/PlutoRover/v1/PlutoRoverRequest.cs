using System.ComponentModel.DataAnnotations;

namespace Api.Contracts.Core.PlutoRover.PlutoRover.v1
{
    public class PlutoRoverRequest
    {
        [Required]
        public string Command { get; set; }
    }
}
