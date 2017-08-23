using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    public static class SortableCollection
    {
        public static void LinearSearch(int[] inputArray, int numToFind)
        {

            for (int i = 0; i < inputArray.Length - 1; i++)
            {

                if (numToFind == inputArray[i])
                {
                    Console.WriteLine("Number {0} is found at index: {1}", inputArray[i].ToString(), i);
                    break;
                }
            }
        }

        public static void BinarySearch(int[] inputArray, int numToFind)
        {
            int min = 0;
            int max = inputArray.Length - 1;

            while (max >= min)
            {

                int mid = (min + max) / 2;

                if (inputArray[mid] == numToFind)
                {
                    Console.WriteLine("Number {0} is at index: {1}", numToFind, mid);
                    break;
                }

                else if (inputArray[mid] > numToFind)
                {
                    max = mid - 1;
                }

                else if (inputArray[mid] < numToFind)
                {
                    min = mid + 1;
                }
            }

        }

        public static void Shuffle(int[] inputArray)
        {
            Random random = new Random();
            int temp = 0;

            for (int i = 0; i < inputArray.Length - 1; i++) // fisher-yates shuffle
            {
                int j = random.Next(i, (inputArray.Length - 1));


                temp = inputArray[i];
                inputArray[i] = inputArray[j];
                inputArray[j] = temp;

            }

            Console.WriteLine(string.Join(", ", inputArray));
        }

    }
}
