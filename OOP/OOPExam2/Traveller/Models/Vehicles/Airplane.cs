using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Vehicles.Contracts;
using Traveller.Models.Vehicles.Enum;

namespace Traveller.Models.Vehicles
{
    public class Airplane : Vehicle, IAirplane
    {
        private bool hasFreeFood;

        public Airplane(int passangerCapacity, decimal pricePerKilometer, bool hasFreeFood) : base(passangerCapacity, pricePerKilometer)
        {
            this.HasFreeFood = hasFreeFood;
            this.Type = VehicleType.Air;
        }

        public bool HasFreeFood
        {
            get
            {
                return this.hasFreeFood;
            }
            set
            {
                this.hasFreeFood = value;
            }
        }
                      

        public override string PrintSpecificInfo()
        {
            return string.Format("\nHas free food: {0}", this.HasFreeFood);
        }

        public override string VehicleName()
        {
            return "Airplane";
        }
    }
}
