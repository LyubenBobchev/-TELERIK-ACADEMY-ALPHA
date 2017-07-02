using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            int equalNumsCounter = 1;
            int maxEqualNums = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {

                if (array[i] == array[i + 1])
                {

                    equalNumsCounter++;

                    if (equalNumsCounter > maxEqualNums)
                    {
                        maxEqualNums = equalNumsCounter;
                    }
                  

                }
                else
                {
                    equalNumsCounter = 1;
                }
            }
            Console.WriteLine(maxEqualNums);
        }
    }
}
