using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SubstringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputSubString = Console.ReadLine();
            string inputText = Console.ReadLine();
            int indexOfSubStr = -1;
            int counter = 0;

            for (int i = 0; i < inputText.Length; i++)
            {
                /* searching for the substring's index.
               If found counter++ and the index is saved and next search starts from it.
               If all occurances are found indexOf method returns -1 and the cycle stops */

                indexOfSubStr = inputText.IndexOf(inputSubString, indexOfSubStr + 1, StringComparison.CurrentCultureIgnoreCase);

                if (indexOfSubStr == -1)
                {
                    break;
                }

                else
                {
                    counter++;
                }

            }
            Console.WriteLine(counter);

        }
    }
}
