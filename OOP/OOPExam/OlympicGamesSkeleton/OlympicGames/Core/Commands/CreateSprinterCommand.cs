using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Core.Commands.Abstracts;
using System;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand : CreateOlympianCommand
    {
        // Consider using the dictionary
        private readonly IDictionary<string, double> records;

        public CreateSprinterCommand(IList<string> commandLine) : base(commandLine)
        {
        }

        public override int InformationCount()
        {
            return 3;
        }

        public override IOlympian Olympian(string firstName, string lastName, string country)
        {
            IDictionary<string, double> records;

            if (CommandParameters.Count > InformationCount())
            {
                string[] hundredMeterStats = this.CommandParameters[3].Split('/');
                string[] twoHundredMeterStats = this.CommandParameters[4].Split('/');

                records = new Dictionary<string, double>()
                {
                    {hundredMeterStats[0],double.Parse(hundredMeterStats[1])},
                    {twoHundredMeterStats[0], double.Parse(twoHundredMeterStats[1])}
                };
            }
            else
            {
                records = null;
            }

            IOlympian sprinter = this.Factory.CreateSprinter(firstName, lastName, country, records);

            return sprinter;
        }

        public override string OlympianType()
        {
            return string.Format("Sprinter");
        }

        
    }
}
