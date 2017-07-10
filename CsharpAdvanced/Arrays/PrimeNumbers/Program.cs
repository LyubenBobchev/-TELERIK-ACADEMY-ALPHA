using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine(SearchPrimeNums(maxNumber));
        }

        public static int SearchPrimeNums(int maxNumber)
        {

            List<int> primeNumbers = new List<int>();
            bool[] checkArray = new bool[maxNumber + 1];

            for (int k = 0; k < checkArray.Length; k++)
            {
                checkArray[k] = true;
            }

            for (int i = 2; i < checkArray.Length; i++)
            {
                if (checkArray[i] == true)
                {
                    primeNumbers.Add(i);

                    for (BigInteger j = i * i; j < checkArray.Length; j += i)
                    {
                        checkArray[(int)j] = false;
                    }
                }

            }

            int biggestPrimeNum = primeNumbers[primeNumbers.Count - 1];
            return biggestPrimeNum;
        }
    }
}
