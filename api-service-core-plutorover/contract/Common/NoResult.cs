using System.Collections.Generic;

namespace Api.Contracts.Core.PlutoRover.Common
{
    public class NoResult
    {
        public bool HasError { get; set; }
        public List<string> Errors { get; set; }
    }
}
