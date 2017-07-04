using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');
            int[] numbers = new int[inputNumbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(inputNumbers[i]);
            }

        }

        public static int CalculateMinumum(int[] numbers)
        {
            int minimum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i] < numbers[i + 1])
                {

                    minimum = numbers[i];

                }

            }

            return minimum;
        }

        public static int CaluculateMaximum(int[] numbers)
        {
            int maximum = 0;

            for (int k = 0; k < numbers.Length - 1; k++)
            {

                if (numbers[k] > numbers[k + 1])
                {

                    maximum = numbers[k];

                }

            }

            return maximum;
        }

        public static double CalculateAvarage(int[] numbers)
        {
            double sum = 0;

            for (int n = 0; n < numbers.Length; n++)
            {

                sum += numbers[n];

            }

            return (sum / numbers.Length);
        }

        public static int CalculateSum(int[] numbers)
        {
            int sum = 0;

            for (int n = 0; n < numbers.Length; n++)
            {

                sum += numbers[n];

            }

            return sum;

        }

        public static int CalculateProduct(int[] numbers)
        {
            int product = 0;

            for (int n = 0; n < numbers.Length; n++)
            {

                product *= numbers[n];

            }

            return product;
        }
    }
}

