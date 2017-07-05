using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            int minIndex = 0;
            int maxIndex = array.Length - 1;
            int numberXindex = -1;


            for (int i = 0; i < array.Length; i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }

            int numberX = int.Parse(Console.ReadLine());

            while (minIndex <= maxIndex)
            {

                
                int midIndex = (minIndex + maxIndex) / 2;

                if (numberX == array[midIndex])
                {

                    numberXindex = midIndex;

                    break;                                   // loop breaks when min max and mid indexes are the same and the number is found.

                }

                else if (numberX < array[midIndex])         //if number is smaller than the middle one.
                {

                    maxIndex = midIndex - 1;

                }

                else                                       //if number is bigger than the middle one.
                {

                    minIndex = midIndex + 1;

                }

            }

            Console.WriteLine(numberXindex);            
        }
    }
}
