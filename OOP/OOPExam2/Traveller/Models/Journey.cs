using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Core;
using Traveller.Models.Contracts;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models
{
    public class Journey : IJourney
    {
        private readonly string destination;
        private readonly int distance;
        private readonly string startLocation;
        private readonly IVehicle vehicle;

        public Journey(string startLocation, string destination, int distance, IVehicle vehicle)
        {
            Validation.ValidateIfNull(destination);
            Validation.ValidateMinAndMaxLength(destination, Constants.DestinationLocationStringMinLength, Constants.DestinationLocationStringMaxLength,
                string.Format(Constants.StringLengthErrorMessage, "Destination"));
            this.destination = destination;

            Validation.ValidateIfNull(destination);
            Validation.ValidateMinAndMaxLength(destination, Constants.StartLocationStringMinLength, Constants.StartLocationStringMaxLength,
                string.Format(Constants.StringLengthErrorMessage, "StartingLocation"));
            this.startLocation = startLocation;

            Validation.ValidateMinAndMaxNumber(distance, Constants.DistanceMinKilometers, Constants.DistanceMaxKilometers,
                Constants.DistanceErrorMessage);
            this.distance = distance;

            this.vehicle = vehicle;

        }

        public string Destination
        {
            get
            {
                return this.destination;
            }
        }

        public int Distance
        {
            get
            {
                return this.distance;
            }
        }

        public string StartLocation
        {
            get
            {
                return this.startLocation;
            }
        }

        public IVehicle Vehicle
        {
            get
            {
                return this.vehicle;
            }
        }

        public decimal CalculateTravelCosts()
        {
            var travelCosts = this.Distance * this.Vehicle.PricePerKilometer;

            return travelCosts;
        }

        public override string ToString()
        {
            return string.Format(@"Journey ----
Start location: {0}
Destination: {1}
Distance: {2}
Vehicle type: {3}
Travel costs: {4}", this.StartLocation, this.Destination,this.Distance, this.Vehicle.Type, this.CalculateTravelCosts());
        }
    }
}
