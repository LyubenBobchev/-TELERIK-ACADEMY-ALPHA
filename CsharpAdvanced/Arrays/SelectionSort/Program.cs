using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        private static int minNum;

        static void Main(string[] args)
        {
            int sizeArray = int.Parse(Console.ReadLine());
            int[] array = new int[sizeArray];
           

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }

            for (int k = 0; k < array.Length; k++)
            {
                int minNumIndex = k;                    //sets the the index of the smallest number to the begining of  array 

                for (int x = k; x < array.Length; x++)
                {

                    if (array[minNumIndex] > array[x])
                    {
                        minNumIndex = x;
                    }
                }
                                                        //swapping after inner loop's all iterations
                int temp = array[k];
                array[k] = array[minNumIndex];
                array[minNumIndex] = temp;

            }
            foreach (var num in array)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
