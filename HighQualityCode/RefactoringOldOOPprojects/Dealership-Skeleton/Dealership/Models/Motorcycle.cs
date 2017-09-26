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
    public class Motorcycle : Vehicle, IMotorcycle
    {
        private readonly string category;

        public Motorcycle(string make, string model, decimal price, string category) : base(make, model, price)
        {
            Validator.ValidateIntRange(category.Length,Constants.MinCategoryLength, Constants.MaxCategoryLength,
                string.Format(Constants.StringMustBeBetweenMinAndMax, "Category", Constants.MinCategoryLength, Constants.MaxCategoryLength));
            this.category = category;
        }

        public string Category
        {
            get
            {
                return this.category;
            }
        }

        public override int Wheels
        {
            get
            {
                return 2;
            }
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Motorcycle;
            }
        }

        public override string PrintAdditionalInfo()
        {
            return string.Format("Category: {0}", this.Category);
        }
    }
}
