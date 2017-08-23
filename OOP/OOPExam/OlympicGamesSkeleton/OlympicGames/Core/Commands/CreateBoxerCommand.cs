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
using OlympicGames.Olympics;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : CreateOlympianCommand
    {
        public CreateBoxerCommand(IList<string> commandLine) : base(commandLine)
        {

        }

        public override int InformationCount()
        {
            return 6;
        }

        public override IOlympian Olympian(string firstName, string lastName, string country)
        {
            string category = this.CommandParameters[3];
            int wins;
            int losses;
            bool winsParse = int.TryParse(this.CommandParameters[4],out wins);
            bool lossesParse = int.TryParse(this.CommandParameters[5],out losses);

            if (!winsParse)
            {
                throw new Exception(GlobalConstants.WinsLossesMustBeNumbers);
            }
            if (!lossesParse)
            {
                throw new Exception(GlobalConstants.WinsLossesMustBeNumbers);
            }

            IOlympian boxer = this.Factory.CreateBoxer(firstName, lastName, country, category, wins, losses);

            return boxer;
        }

        public override string OlympianType()
        {
            return string.Format("Boxer");
        }
    }
}
