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
    public class Boxer : Olympian, IBoxer, IOlympian
    {
        private BoxingCategory category;
        private int wins;
        private int losses;

        public Boxer(string firstName, string lastName, string country, BoxingCategory category, int wins, int losses) : base(firstName, lastName, country)
        {
            this.Category = category;
            this.Wins = wins;
            this.Losses = losses;
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
                if (!Enum.IsDefined(typeof(BoxingCategory), value))
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
                Validator.ValidateIfNull(value);
                Validator.ValidateMinAndMaxNumber(value, 0, 100, "Wins must be between 0 and 100!");
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
                Validator.ValidateIfNull(value);
                Validator.ValidateMinAndMaxNumber(value, 0, 100, "Losses must be between 0 and 100!");
                this.losses = value;
            }
        }

        public override string OlympianType()
        {
            return string.Format("BOXER");
        }

        public override string PrintAdditionalInfo()
        {
            return string.Format("Category: {0}\nWins: {1}\nLosses: {2}", this.Category, this.Wins, this.Losses);
        }

        


    }
}
