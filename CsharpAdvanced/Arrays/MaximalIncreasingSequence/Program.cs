using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIcreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            int biggerNumCounter = 1;
            int maxEqualNums = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {

                if (array[i] < array[i + 1])
                {

                    biggerNumCounter++;

                    if (biggerNumCounter > maxEqualNums)
                    {
                        maxEqualNums = biggerNumCounter;
                    }


                }
                else
                {
                    biggerNumCounter = 1;
                }
            }
            Console.WriteLine(maxEqualNums);
        }
    }
}
