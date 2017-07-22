using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(SearchPrimeNums(maxNumber));
        }

        public static int SearchPrimeNums(double maxNumber)
        {

            List<int> primeNumbers = new List<int>();
            bool[] checkArray = new bool[(int)maxNumber + 1];

            for (int k = 0; k < checkArray.Length; k++)
            {
                checkArray[k] = true;
            }

            for (int i = 2; i < checkArray.Length; i++)
            {
                if (checkArray[i] == true)
                {
                    primeNumbers.Add(i);

                    for (int j = i * i; j < maxNumber + 1; j += i)
                    {
                        checkArray[j] = false;
                    }
                }

            }

            int biggestPrimeNum = primeNumbers[primeNumbers.Count - 1];
            return biggestPrimeNum;
        }
    }
}
