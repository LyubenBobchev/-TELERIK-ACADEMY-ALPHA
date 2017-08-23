using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste
    {
        private readonly IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType genderType, IList<string> ingridients) : base(name, brand, price, genderType)
        {
            
            this.ingredients = ingridients;
        }

        public string Ingredients
        {
            get
            {
                return string.Join(", ", this.ingredients);
            }
        }

        public override string Print()
        {
            return string.Format(@"* Ingredients: {0}", this.Ingredients);
        }
    }
}
