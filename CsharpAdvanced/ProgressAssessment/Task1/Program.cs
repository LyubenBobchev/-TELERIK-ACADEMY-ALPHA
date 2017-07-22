using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var file = new StreamReader("C:/Users/lyubo/Desktop/test.txt");

            string inputNumber = Console.ReadLine();
            List<int> numbers = new List<int>(inputNumber.Length);

            int j = 0;
            long s = 0;
            char[] alphabet = new char[] { '0', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < inputNumber.Length; i++, j++)
            {
                if (inputNumber[i] == '-')
                {

                    numbers.Add(int.Parse(inputNumber[i + 1].ToString()));
                    i++;
                }
                else
                {
                    numbers.Add(int.Parse(inputNumber[i].ToString()));
                }
            }


            long result = 0;
            long index = numbers.Count;

            for (int k = 0; k < numbers.Count; k++)
            {
                if (index % 2 != 0)
                {
                    result += numbers[k] * index * index;
                }

                else
                {
                    result += numbers[k] * numbers[k] * index;
                }

                index--;
            }

            Console.WriteLine(result);

            long lastDigit = result % 10;


            if (result % 10 == 0)
            {
                Console.WriteLine("Big Vik wins again!");
            }

            else
            {
                s =(result % 26) + 1;

                for (int i = 0; i < lastDigit; i++)
                {
                    Console.Write(alphabet[s]);
                    if (alphabet[s] == 'Z')
                    {
                        s = 0;
                    }

                    s++;
                }
            }

        }
    }
}
