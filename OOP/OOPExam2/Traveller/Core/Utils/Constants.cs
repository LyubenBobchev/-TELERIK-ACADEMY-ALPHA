using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Core
{
    public static class Constants
    {
        public const int VehicleMinCapacity = 1;
        public const int VehicleMaxCapacity = 800;
        public const decimal MinPricePerKilometer = 0.10m;
        public const decimal MaxPricePerKilometer = 2.5m;

        public const int TrainMinCapacity = 30;
        public const int TrainMaxCapacity = 150;
        public const int TrainMaxCarts = 15;
        public const int TrainMinCarts = 1;

        public const int BusMinCapacity = 10;
        public const int BusMaxCapacity = 50;

        public const int StartLocationStringMinLength = 5;
        public const int StartLocationStringMaxLength = 25;

        public const int DestinationLocationStringMinLength = 5;
        public const int DestinationLocationStringMaxLength = 25;

        public const int DistanceMinKilometers = 5;
        public const int DistanceMaxKilometers = 5000;

        public const string CapacityErrorMessage = "A {0} cannot have less than {1} passengers or more than {2} passengers.";
        public const string CartsErrorMessage = "A train cannot have less than 1 cart or more than 15 carts.";

        public const string StringLengthErrorMessage = "The {0}'s length cannot be less than 5 or more than 25 symbols long.";
        public const string DistanceErrorMessage = "The Distance cannot be less than 5 or more than 5000 kilometers.";        public const string PriceErrorMessage = "A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!";



    }
}
