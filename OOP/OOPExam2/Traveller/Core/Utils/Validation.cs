using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Core
{
    public static class Validation
    {

        public static void ValidateMinAndMaxNumber(this int value, int min, int max = int.MaxValue - 1, string msg = null)
        {
            if (msg == null)
            {
                msg = string.Format("Value must be between {0} and {1}!", min, max);
            }

            if (value < min || value > max)
            {
                throw new ArgumentOutOfRangeException(msg);
            }
        }
        public static void ValidateMinAndMaxDecimal(this decimal value, decimal min, decimal max = decimal.MaxValue - 1, string msg = null)
        {
            if (msg == null)
            {
                msg = string.Format("Value must be between {0} and {1}!", min, max);
            }

            if (value < min || value > max)
            {
                throw new ArgumentOutOfRangeException(msg);
            }
        }

        public static void ValidateMinAndMaxLength(this string value, int min, int max = int.MaxValue - 1, string msg = null)
        {
            if (msg == null)
            {
                msg = string.Format("Value must be between {0} and {1} characters long!", min, max);
            }

            if (value.Length < min || value.Length > max)
            {
                throw new ArgumentOutOfRangeException(msg);
            }
        }

        public static void ValidateIfNull(this object value, string msg = null)
        {
            if (msg == null)
            {
                msg = "Value cannot be null!";
            }

            if (value == null)
            {
                throw new ArgumentNullException(msg);
            }
        }
    }
}
