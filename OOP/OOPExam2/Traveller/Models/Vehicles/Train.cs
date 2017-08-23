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
    public class Train : Vehicle, ITrain
    {
        private VehicleType type;
        private readonly int carts;

        public Train(int passangerCapacity, decimal pricePerKilometer,int carts) : base(passangerCapacity, pricePerKilometer)
        {
            Validation.ValidateMinAndMaxNumber(passangerCapacity, Constants.TrainMinCapacity, Constants.TrainMaxCapacity,
                string.Format(Constants.CapacityErrorMessage, "train", Constants.TrainMinCapacity, Constants.TrainMaxCapacity));
                        
            Validation.ValidateMinAndMaxNumber(carts, Constants.TrainMinCarts, Constants.TrainMaxCarts,
                string.Format(Constants.CartsErrorMessage));
            this.carts = carts;

            this.Type = VehicleType.Land;
        }

        

        public int Carts
        {
            get
            {
                return this.carts;
            }
        }

        VehicleType ITrain.Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type =  value;
            }
        }

        public override string PrintSpecificInfo()
        {
            return string.Format("\nCarts amount: {0}", this.Carts);
        }

        public override string VehicleName()
        {
            return "Train";
        }
    }
}
