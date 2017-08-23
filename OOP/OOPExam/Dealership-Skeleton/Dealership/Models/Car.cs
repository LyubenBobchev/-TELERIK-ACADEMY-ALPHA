using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Common;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        private readonly int seats;
               
        public Car(string make, string model, decimal price, int seats) : base(make, model, price)
        {
            Validator.ValidateIntRange(seats, Constants.MinSeats, Constants.MaxSeats,
                string.Format(Constants.NumberMustBeBetweenMinAndMax, "Seats", Constants.MinSeats, Constants.MaxSeats));
            this.seats = seats;
            
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }
        }

        public override int Wheels
        {
            get
            {
                return 4;
            }

        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Car;
            }
        }

        public override string PrintAdditionalInfo()
        {
            return string.Format(@"Seats: {0}", this.Seats);
        }
    }
}
