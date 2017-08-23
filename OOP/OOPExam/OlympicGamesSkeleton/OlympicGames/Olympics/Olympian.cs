using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Olympics
{
    public abstract class Olympian : IOlympian
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly string country;

        public Olympian(string firstName, string lastName, string country)
        {
            Validator.ValidateIfNull(firstName, null);
            Validator.ValidateMinAndMaxLength(firstName, 2, 20, "First name must be between 2 and 20 characters long!");
            this.firstName = firstName;

            Validator.ValidateIfNull(lastName, null);
            Validator.ValidateMinAndMaxLength(lastName, 2, 20, "Last name must be between 2 and 20 characters long!");
            this.lastName = lastName;

            Validator.ValidateIfNull(country, null);
            Validator.ValidateMinAndMaxLength(country, 3, 25, "Country must be between 3 and 25 characters long!");
            this.country = country;
        }

        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public string Country { get { return this.country; } }

        public abstract string OlympianType();
        
        public abstract string PrintAdditionalInfo();
       
        public override string ToString()
        {
            return string.Format("{0}: {1} {2} from {3}\n{4}",this.OlympianType(), this.FirstName, this.LastName, this.Country, this.PrintAdditionalInfo());
        }
    }
}
