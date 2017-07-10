using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            StringBuilder toUpper = new StringBuilder();
            string upCase = "<upcase>";
            string endUpCase = "</upcase>";
            int upCaseIndex = -1; //last index of <upcase>
            int endUpCaseIndex = -1;  //first index of </upcase>


            for (int i = 0; i < inputText.Length; i++)
            {

                upCaseIndex = inputText.IndexOf(upCase, upCaseIndex + 1);
                endUpCaseIndex = inputText.IndexOf(endUpCase, endUpCaseIndex + 1);

                textToUpper[]


            }
        }




    }
}

