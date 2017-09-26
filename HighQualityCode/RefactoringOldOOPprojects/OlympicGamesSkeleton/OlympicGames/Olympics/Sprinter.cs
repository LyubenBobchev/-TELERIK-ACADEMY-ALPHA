using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Olympics
{
    public class Sprinter : Olympian, ISprinter, IOlympian
    {
        private IDictionary<string, double> personalRecords;

        public Sprinter(string firstName, string lastName, string country, IDictionary<string, double> personalRecords) : base(firstName, lastName, country)
        {
            this.PersonalRecords = personalRecords;
        }


        public IDictionary<string, double> PersonalRecords
        {
            get
            {
                return this.personalRecords;
            }
            private set
            {
                this.personalRecords = value;
            }
        }

        public override string OlympianType()
        {
            return string.Format("SPRINTER");
        }

        public override string PrintAdditionalInfo()
        {
            if (this.PersonalRecords == null)
            {
                return GlobalConstants.NoPersonalRecordsSet;
            }
            else
            {
                return string.Format("{0}\n100m: {1}s\n200m: {2}s\n", GlobalConstants.PersonalRecords, this.PersonalRecords["100"],this.PersonalRecords["200"]);
            }
        }


    }
}
