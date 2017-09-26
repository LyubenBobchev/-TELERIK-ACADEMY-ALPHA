using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public static class Utils
    {
        public static void CheckForNegativeNums(decimal num)
        {
            if (num <= 0)
            {
                throw new ArgumentException("Cannot be less or equal to zero!");
            }
        }
    }
}
