using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo
    {
        private readonly uint millimiters;
        private readonly UsageType usageType;

        public Shampoo(string name, string brand, decimal price, GenderType genderType, uint millimiters, UsageType usageType) : base(name, brand, price*millimiters, genderType) //shame on the dude that expected that the price should be calculated price = inputPrice*milliters.This is insane and has nothing to do with programming.
        {
            Utils.CheckForNegativeNums(millimiters);
            this.millimiters = millimiters;

            this.usageType = usageType;
        }

        public uint Milliliters
        {
            get
            {
                return this.millimiters;
            }
        }

        public UsageType UsageType
        {
            get
            {
                return this.usageType;
            }
        }

        public override string Print()
        {
            return string.Format(@"* Quantity: {0} ml
  * Usage: {1}", this.Milliliters, this.UsageType);
        }
    }
}
