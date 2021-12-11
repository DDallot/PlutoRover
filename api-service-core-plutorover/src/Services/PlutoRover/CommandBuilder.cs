using Api.Services.Core.PlutoRover.Services.PlutoRover.Commands;
using System.Collections.Generic;
using System.Linq;

namespace Api.Services.Core.PlutoRover.Services.PlutoRover
{
    public class CommandBuilder
    {
        public Dictionary<char, ICommand> Commands { get; }

        public CommandBuilder(IEnumerable<ICommand> commands)
        {
            Commands = commands.ToDictionary(k => k.Key, c => c);
        }
    }
}