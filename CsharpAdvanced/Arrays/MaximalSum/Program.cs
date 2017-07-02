using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = int.Parse(Console.ReadLine());
            int[] array = new int[sizeArray];
            int maxSum = int.MinValue;
            int currentSum = 0;

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }

            for (int k = 1; k < array.Length; k++)
            {
                currentSum += array[k];             //adds current number to the sum so far

                if (currentSum < array[k])         //checks if current sum is smaller that the current number.If true summing starts over.
                {

                    currentSum = array[k];

                }

                if (currentSum > maxSum)
                {

                    maxSum = currentSum;

                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
