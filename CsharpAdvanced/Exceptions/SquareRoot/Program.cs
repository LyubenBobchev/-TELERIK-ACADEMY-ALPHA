using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ReadNumber(1, 100);
            }
            catch (Exception)
            {

                Console.WriteLine("Exception");
            }
        }

        public static void ReadNumber(int start, int end)
        {
            int[] numbers = new int[10];

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());

                    if (numbers[i] < start || numbers[i] > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                }
                for (int k = 0; k < 9; k++)
                {
                    if (numbers[k] > numbers[k + 1])
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            Console.Write(start + " < ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(numbers[i] + " < ");
            }
            Console.Write(end);
        }
    }
}
