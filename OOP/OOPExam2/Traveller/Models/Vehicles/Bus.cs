using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Core;
using Traveller.Models.Vehicles.Contracts;
using Traveller.Models.Vehicles.Enum;

namespace Traveller.Models.Vehicles
{
    public class Bus : Vehicle, IBus
    {
        public Bus(int passangerCapacity, decimal pricePerKilometer) : base(passangerCapacity, pricePerKilometer)
        {
            Validation.ValidateMinAndMaxNumber(passangerCapacity, Constants.BusMinCapacity, Constants.BusMaxCapacity,
               string.Format(Constants.CapacityErrorMessage, "bus", Constants.BusMinCapacity, Constants.BusMaxCapacity));

            this.Type = VehicleType.Land;
        }

        

        public override string PrintSpecificInfo()
        {
            return "";
        }

        public override string VehicleName()
        {
            return "Bus";
        }
    }
}
