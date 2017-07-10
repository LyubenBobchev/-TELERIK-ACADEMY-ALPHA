using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../test.txt";
            var reader = new StreamReader(filePath);

            using (reader)
            {
                int lineNumber = 1;
                string line = "";

                while (line != null)
                {

                    line = reader.ReadLine();
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    lineNumber++;
                }
            }
        }

    }
}

