using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            StringBuilder stringFiller = new StringBuilder();
            

            if (inputString.Length <= 20)
            {
                for (int i = inputString.Length; i < 20; i++)
                {
                    stringFiller.Append("*");
                }
            }
            Console.WriteLine(inputString + stringFiller);
        }
    }
}
