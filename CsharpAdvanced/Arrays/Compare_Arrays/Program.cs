using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());

            int[] arrayA = new int[arraySize];
            int[] arrayB = new int[arraySize];
            bool equal = true;

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {

                arrayA[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < arrayB.GetLength(0); i++)
            {

                arrayB[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {

                if (arrayA[i] != arrayB[i])
                {
                    equal = false;
                }
                
            }

            if (equal == true)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
