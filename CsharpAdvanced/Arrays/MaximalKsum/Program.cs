using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKsum
{
    //using bubble sort to sort elements in a ascending order then use the last 3 numbers and add them

    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = int.Parse(Console.ReadLine());
            int numsToBeAdded = int.Parse(Console.ReadLine());
            int[] array = new int[sizeArray];
            int biggernum = 0;
            int sum = 0;



            for (int i = 0; i < array.GetLength(0); i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }

            //worst case scenario of needed iterations is n - 1 where n is the number of elements in the array

            for (int k = 0; k < array.GetLength(0) - 1; k++) 
            {
                
                for (int i = 0; i < array.GetLength(0) - 1; i++)
                {

                    if (array[i] > array[i + 1])
                    {

                        biggernum = array[i + 1];

                        array[i + 1] = array[i];

                        array[i] = biggernum;

                    }

                }

            }

            //adding last k sorted numbers which are guaranteed to make the biggest sum
            int arrayIndex = array.GetLength(0) - 1;

            while (numsToBeAdded != 0)
            {
                sum += array[arrayIndex];

                arrayIndex--;

                numsToBeAdded--;

            }

            Console.WriteLine(sum);
            

            
        }
    }
}
