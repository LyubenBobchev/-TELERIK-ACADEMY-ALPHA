using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class FindMostFriquetNumber
{
    static void Main()
    {
        List<string> asad = new List<string>();
        string filePath = "D:/______SOFTDEVELOP/__TELERIK/ALPHA/OOP/OOPPrinciples1/Problem2/StudentsInfo.txt";
       string ada  = File.ReadLines(filePath).Skip(3).Take(1).First();
        Console.WriteLine(ada);
    } 
}