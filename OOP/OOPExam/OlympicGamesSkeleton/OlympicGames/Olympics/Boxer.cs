using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Olympics
{
    public class Boxer : IBoxer, IOlympian
    {
        private readonly string firstName;
        private readonly string lastName;
        private string country;
        private BoxingCategory category;
        private int wins;
        private int losses;

        public Boxer(string firstName, string lastName, string country, BoxingCategory category, int wins, int losses)
        {
            Validator.ValidateMinAndMaxLength(firstName, 2, 20, null);
            this.firstName = firstName;

            Validator.ValidateMinAndMaxLength(lastName, 2, 20, null);
            this.lastName = lastName;

            this.Country = country;
            this.Category = category;
            this.Wins = wins;
            this.Losses = losses;
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

        public BoxingCategory Category
        {
            get
            {
                return this.category;
            }
            private set
            {
                Validator.ValidateIfNull(value, null);
                if (!Enum.IsDefined(typeof(BoxingCategory),value))
                {
                    throw new ArgumentException("Invalid category");
                }
                this.category = value;
            }
        }

        public int Wins
        {
            get
            {
                return this.wins;
            }
            private set
            {
                Validator.ValidateMinAndMaxNumber(value, 0, 100, null);
                this.wins = value;
            }
        }

        public int Losses
        {
            get
            {
                return this.losses;
            }
            private set
            {
                Validator.ValidateMinAndMaxNumber(value, 0, 100, null);
                this.losses = value;
            }
        }

        public override string ToString()
        {
            return string.Format(@"Created Boxer \n
                                    BOXER: {0} {1} from {2}\n
                                    Category: {3}\n
                                    Wins: {4} \n
                                    Losses: {5} ",this.FirstName, this.LastName,this.Category, this.Wins, this.Losses);//???
        }


    }
}
