using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            char[] alphabet = new char[26];
            char letter = 'a';
           
            for (int i = 0; i < alphabet.Length; i++, letter++)
            {

                alphabet[i] = letter;

            }

            char [] convertedWord = inputWord.ToCharArray();

            foreach (var character in convertedWord)
            {

                Console.WriteLine(character - 97); // subtract 97 to get the position in the alphabet

            }
        }
    }
}
