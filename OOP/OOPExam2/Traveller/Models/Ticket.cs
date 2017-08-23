using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Contracts;

namespace Traveller.Models
{
    public class Ticket : ITicket
    {
        private readonly decimal administrativeCosts;
        private readonly IJourney journey;

        public Ticket(IJourney journey, decimal adminstrativeCosts)
        {
            this.journey = journey;
            if (administrativeCosts <= 0)
            {
                throw new ArgumentException("Administrative costs cannot be less than or equal to zero");
            }
            this.administrativeCosts = adminstrativeCosts;
        }

        public decimal AdministrativeCosts
        {
            get
            {
                return this.administrativeCosts;
            }
        }

        public IJourney Journey
        {
            get
            {
                return this.journey;
            }
        }

        public decimal CalculatePrice()
        {
            var price = this.Journey.CalculateTravelCosts() + this.AdministrativeCosts;

            return price;
        }
    }
}
