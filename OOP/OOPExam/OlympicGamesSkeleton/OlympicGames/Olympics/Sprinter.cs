using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Olympics
{
    public class Sprinter : ISprinter, IOlympian
    {
        private readonly string firstName;
        private readonly string lastName;
        private string country;
        private IDictionary<string, double> personalRecords;

        public Sprinter(string firstName, string lastName, string country, IDictionary<string, double> personalRecords)
        {
            Validator.ValidateMinAndMaxLength(firstName, 2, 20, null);
            this.firstName = firstName;

            Validator.ValidateMinAndMaxLength(lastName, 2, 20, null);
            this.lastName = lastName;

            this.Country = country;
            this.PersonalRecords = personalRecords;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public string Country
        {
            get
            {
                return this.country;
            }
            private set
            {
                Validator.ValidateMinAndMaxLength(value, 3, 25, null);
                this.country = value;
            }
        }

        public IDictionary<string, double> PersonalRecords
        {
            get
            {
                return this.personalRecords;
            }
            private set
            {
                Validator.ValidateIfNull(value, null);
                this.personalRecords = value;
            }
        }

        public override string ToString()
        {
            return string.Format(@"Created Sprinter\n
                                    SPRINTER: {0} {1} from {2}\n
                                    PERSONAL RECORDS: {3}\n"
                                    ,this.FirstName, this.LastName, this.PersonalRecords);//???
        }
    }
}
