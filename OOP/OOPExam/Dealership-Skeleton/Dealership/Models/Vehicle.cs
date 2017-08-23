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
    public abstract class Vehicle : IVehicle
    {
        private decimal price;
        private string model;
        private string make;

        public Vehicle(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Comments = new List<IComment>();
        }

        public abstract int Wheels
        {
            get;
        }

        public abstract VehicleType Type
        {
            get;
        }

        public string Make
        {
            get
            {
                return this.make;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinMakeLength, Constants.MaxMakeLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Make", Constants.MinMakeLength, Constants.MaxMakeLength));

                this.make = value;
            }

        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinModelLength, Constants.MaxModelLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Model", Constants.MinModelLength, Constants.MaxModelLength));

                this.model = value;
            }
        }

        public IList<IComment> Comments
        {
            get;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax, "Price", Constants.MinPrice, Constants.MaxPrice));
                this.price = value;
            }

        }
        public abstract string PrintAdditionalInfo();

        public override string ToString()
        {
            return string.Format(@"{0}:
  Make: {1}
  Model: {2}
  Wheels: {3}
  Price: ${4}
  {5}
    {6}", this.Type, this.Make, this.Model, this.Wheels, this.Price, this.PrintAdditionalInfo(), this.Comments.Count == 0 ? "--NO COMMENTS--" : string.Format(@"--COMMENTS--
    ----------
{0}
    --COMMENTS--
    ----------", string.Join("\n", this.Comments)));
        }
    }
}
