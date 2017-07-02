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
            int repeatingNum = 0;
            int numCounter = 0;
            int maxCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }

            for (int k = 0; k < array.Length; k++)
            {

                for (int x = 0; x < array.Length; x++)
                {

                    if (array[k] == array[x])
                    {

                        numCounter++;

                    }

                }

                if (numCounter > maxCounter)
                {

                    maxCounter = numCounter;
                    repeatingNum = array[k];
                    

                }

                numCounter = 0;
            }



            Console.WriteLine("{0} ({1} times)", repeatingNum, maxCounter);
        }
    }
}
