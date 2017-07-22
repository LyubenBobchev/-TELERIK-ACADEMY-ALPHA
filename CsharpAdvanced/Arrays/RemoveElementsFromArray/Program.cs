using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int removeNumCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < numbers.Length - 1; k++)
            {
                if (numbers[k] > numbers[k + 1])
                {
                    removeNumCounter++;
                }
            }
            Console.WriteLine(removeNumCounter);
        }
    }
}
