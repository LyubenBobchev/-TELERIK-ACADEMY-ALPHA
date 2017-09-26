using Dealership.Common;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;

namespace Dealership.Models
{
    public class Truck : Vehicle, ITruck
    {
        private readonly int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity) : base(make, model, price)
        {
            Validator.ValidateIntRange(weightCapacity, Constants.MinCapacity, Constants.MaxCapacity,
                string.Format(Constants.NumberMustBeBetweenMinAndMax, "Weight capacity", Constants.MinCapacity, Constants.MaxCapacity));
            this.weightCapacity = weightCapacity;
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }
        }

        public override int Wheels
        {
            get
            {
                return 8;
            }
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Truck;
            }
        }

        public override string PrintAdditionalInfo()
        {
            return string.Format("Weight Capacity: {0}t", this.WeightCapacity);
        }
    }
}
