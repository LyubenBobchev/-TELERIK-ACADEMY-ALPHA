using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;
using System.Collections.Generic;
using System;
using OlympicGames.Utils;
using OlympicGames.Olympics.Contracts;

namespace OlympicGames.Core.Commands
{
    public abstract class CreateOlympianCommand : Command
    {
        public CreateOlympianCommand(IList<string> commandLine) : base(commandLine)
        {
        }

        public override string Execute()
        {
            if (CommandParameters.Count < this.InformationCount())
            {
                throw new Exception(GlobalConstants.ParametersCountInvalid);
            }

            string firstName = this.CommandParameters[0];
            string lastName = this.CommandParameters[1];
            string country = this.CommandParameters[2];

            IOlympian olympian = this.Olympian(firstName, lastName, country);

            this.Committee.Olympians.Add(olympian);
            return string.Format("Created {0}\n{1}", this.OlympianType(), olympian.ToString());
        }

        public abstract int InformationCount();
        public abstract IOlympian Olympian(string firstName, string lastName, string country);
        public abstract string OlympianType();
    }
}
