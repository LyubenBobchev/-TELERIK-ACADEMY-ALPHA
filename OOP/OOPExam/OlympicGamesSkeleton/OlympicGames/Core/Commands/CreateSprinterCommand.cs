using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Core.Commands.Abstracts;
using System;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand : Command
    {
        // Consider using the dictionary
        private readonly IDictionary<string, double> records;

        public CreateSprinterCommand(IList<string> commandLine) : base(commandLine)
        {
        }

        public override string Execute()
        {
            throw new NotImplementedException();
        }
    }
}
