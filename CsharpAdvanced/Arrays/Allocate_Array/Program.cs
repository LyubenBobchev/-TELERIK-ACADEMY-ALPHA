using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int[] array = new int[inputNumber];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = i * 5;

                Console.WriteLine(array[i]);
            }
           
        }
    }
}
