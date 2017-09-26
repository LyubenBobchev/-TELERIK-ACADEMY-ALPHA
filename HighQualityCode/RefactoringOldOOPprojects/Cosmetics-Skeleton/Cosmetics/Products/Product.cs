using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private readonly string name;
        private readonly string brand;
        private readonly decimal price;
        private readonly GenderType genderType;

        public Product(string name, string brand, decimal price, GenderType genderType)
        {
            Validator.CheckIfStringIsNullOrEmpty(name, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product name"));
            Validator.CheckIfStringLengthIsValid(name, 10, 3, (string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", 3, 10)));
            this.name = name;

            Validator.CheckIfStringIsNullOrEmpty(brand, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product brand"));
            Validator.CheckIfStringLengthIsValid(brand, 10, 2, (string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", 2, 10)));
            this.brand = brand;

            Utils.CheckForNegativeNums(price);
            this.price = price;

            if (!Enum.IsDefined(typeof(GenderType), genderType))
            {
                throw new ArgumentException("Invalid gender");
            }

            this.genderType = genderType;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.genderType;
            }
        }

        public abstract string Print();

        public override string ToString()
        {
            return string.Format(@"- {0} - {1}:
  * Price: ${2}
  * For gender: {3}
  {4}", this.Brand, this.Name, this.Price, this.Gender, this.Print());
        }

    }
}
