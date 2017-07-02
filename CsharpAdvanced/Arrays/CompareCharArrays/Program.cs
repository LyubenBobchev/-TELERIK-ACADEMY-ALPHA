using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int str1Lenght = str1.Length;
            int str2Lenght = str2.Length;



            for (int i = 0; i < Math.Min(str1Lenght, str2Lenght); i++)
            {

                if (str1[i] < str2[i])
                {
                    Console.WriteLine("<");

                    return;
                }
                else if (str1[i] > str2[i])
                {
                    Console.WriteLine(">");

                    return;
                }
            }
            if (str1Lenght < str2Lenght)
            {
                Console.WriteLine("<");
            }
            else if (str1Lenght > str2Lenght)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("=");
            }

        }
    }
}

