using System;
using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Olympics.Enums;
using OlympicGames.Core.Factories;
using OlympicGames.Core.Commands.Abstracts;
using System.Text;
using System.Linq;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : Command
    {
        
        public CreateBoxerCommand(IList<string> commandLine) : base(commandLine)
        {
            
        }

        public override string Execute()
        {
            throw new NotImplementedException();
        }
    }
}
