using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            
            int numCounter = 1;
            int maxCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }

            int repeatingNum = array[0];

            for (int k = 1; k < array.Length; k++)
            {

                if (array[k] == array[k - 1])
                {

                    numCounter++;

                }

                if (array[k] == repeatingNum)
                {

                    numCounter++;

                }

                if (numCounter > maxCounter)
                {

                    maxCounter = numCounter;
                    repeatingNum = array[k];

                }
            }

            Console.WriteLine("{0} ({1} times)", repeatingNum, maxCounter);
        }
    }
}
