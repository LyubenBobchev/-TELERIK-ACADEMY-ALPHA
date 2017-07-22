using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            string arrayInput = Console.ReadLine();
            int arrayIndex = startIndex;


            int forwardSum = 0;
            int backwardSum = 0;

            string[] stringArray = arrayInput.Split(',');
            int[] array = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                array[i] = int.Parse(stringArray[i].ToString());
            }

            string instructions = Console.ReadLine();

            while (instructions != "exit")
            {
                string[] splitInstr = instructions.Split(' ');
                int step = int.Parse(splitInstr[0].ToString());
                int size = int.Parse(splitInstr[2].ToString());


                switch (splitInstr[1])
                {
                    case "forward":

                        for (int i = arrayIndex; step > 0; step--)
                        {
                            if (i + size > array.Length - 1)
                            {
                                i = (i + size) % array.Length;
                            }
                            else
                            {
                                i += size;
                            }

                            forwardSum += array[i];
                            arrayIndex = i;

                        }

                        break;

                    case "backwards":

                        Array.Reverse(array);
                        arrayIndex = Math.Abs(arrayIndex - (array.Length - 1));

                        for (int i = arrayIndex; step > 0; step--)
                        {
                            if (i + size > array.Length - 1)
                            {
                                i = (i + size) % array.Length;
                            }
                            else
                            {
                                i += size;
                            }

                            backwardSum += array[i];
                            arrayIndex = i;
                        }

                        Array.Reverse(array);
                        arrayIndex = Math.Abs(arrayIndex - (array.Length - 1));

                        break;

                }

                instructions = Console.ReadLine();

            }

            Console.WriteLine("Forward: {0}", forwardSum);
            Console.WriteLine("Backwards: {0}", backwardSum);
        }
    }
}
