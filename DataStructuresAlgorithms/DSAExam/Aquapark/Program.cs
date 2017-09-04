using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquapark
{
    public class Program
    {
        private static Queue<int> people = new Queue<int>();

        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var inputCommands = Console.ReadLine().Split(' ');
                var command = inputCommands[0];
                switch (command)
                {
                    case "add":
                        AddPeople(inputCommands);
                        break;

                    case "slide":
                        SlidePeople(inputCommands);
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", people.Reverse()));
                        break;

                    default:
                        break;
                }

            }
        }
        private static void AddPeople(string[] inputCommands)
        {
            people.Enqueue(int.Parse(inputCommands[1]));
            Console.WriteLine(string.Format("Added {0}", inputCommands[1]));
        }

        private static void SlidePeople(string[] inputCommands)
        {
            people = Slide(people, int.Parse(inputCommands[1]));
            Console.WriteLine(string.Format("Slided {0}", inputCommands[1]));
        }

        private static Queue<int> Slide(Queue<int> queue, int people)
        {
            for (int i = 0; i < people; i++)
            {
                var slidedPoepple = queue.Dequeue();
                queue.Enqueue(slidedPoepple);
            }

            return queue;
        }
    }
}


