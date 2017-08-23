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
    public abstract class Vehicle : IVehicle
    {
        private readonly int passangerCapacity;
        private decimal pricePerKilometer;
        
        public Vehicle(int passangerCapacity, decimal pricePerKilometer)
        {
            Validation.ValidateMinAndMaxNumber(passangerCapacity, Constants.VehicleMinCapacity, Constants.VehicleMaxCapacity,
                string.Format(Constants.CapacityErrorMessage, "vehicle", Constants.VehicleMinCapacity, Constants.VehicleMaxCapacity));
            this.passangerCapacity = passangerCapacity;

            Validation.ValidateMinAndMaxDecimal(pricePerKilometer, Constants.MinPricePerKilometer, Constants.MaxPricePerKilometer,
                string.Format(Constants.PriceErrorMessage));
            this.PricePerKilometer = pricePerKilometer;

        }

        public int PassangerCapacity
        {
            get
            {
                return this.passangerCapacity;
            }
        }

        public decimal PricePerKilometer
        {
            get
            {
                return this.pricePerKilometer;
            }
            private set
            {
                Validation.ValidateMinAndMaxDecimal(value, Constants.MinPricePerKilometer, Constants.MaxPricePerKilometer,string.Format(Constants.PriceErrorMessage));
                this.pricePerKilometer = value;
            }
        }

        public VehicleType Type { get; set; }

        public abstract string PrintSpecificInfo();
        public abstract string VehicleName();

        public override string ToString()
        {
            return string.Format(@"{0} ----
Passenger capacity: {1}
Price per kilometer: {2}
Vehicle type: {3}{4}", this.VehicleName(), this.PassangerCapacity, this.PricePerKilometer, this.Type, this.PrintSpecificInfo());
        }

    }
}
