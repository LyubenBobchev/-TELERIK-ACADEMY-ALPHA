using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace DogLovesPaper
{

    public class Program
    {
        static SortedSet<Node> allNodes = new SortedSet<Node>();
        static Stack<Node> nodeSet = new Stack<Node>();
        static HashSet<int> sortedNodes = new HashSet<int>();


        public static void Main(string[] args)
        {
            int inputnumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputnumber; i++)
            {
                string[] inputstring = Console.ReadLine().Split(' ');
                int numA = int.Parse(inputstring[0]);
                int numB = int.Parse(inputstring[3]);
                string instructions = inputstring[2];


                switch (instructions)
                {
                    case "after":
                        Node parentNode = new Node() { Number = numB, HasPrev = false };
                        Node childNode = new Node() { Number = numA, HasPrev = true };
                        parentNode.Next.Add(childNode);
                        allNodes.Add(parentNode);
                        allNodes.Add(childNode);
                        break;

                    case "before":
                        Node parentNode2 = new Node() { Number = numA, HasPrev = false };
                        Node childNode2 = new Node() { Number = numB, HasPrev = true };
                        parentNode2.Next.Add(childNode2);
                        allNodes.Add(parentNode2);
                        allNodes.Add(childNode2);
                        break;
                }
            }

            foreach (var item in allNodes.Where(x => x.HasPrev == false))
            {
                nodeSet.Push(item);
            }

            do
            {
                var currentNode = nodeSet.Pop();
                foreach (var node in currentNode.Next)
                {
                    node.HasPrev = false;
                }
                sortedNodes.Add(currentNode.Number);

                foreach (var node in currentNode.Next)
                {
                    if (node.HasPrev == false && !nodeSet.Contains(node))
                    {
                        nodeSet.Push(node);
                    }
                }
            } while (nodeSet.Count != 0);

            foreach (var node in sortedNodes)
            {
                Console.Write(node);
            }
        }
    }

    public class Node : IComparable<Node>
    {
        public Node()
        {
            this.Next = new List<Node>();
        }

        public int Number { get; set; }
        public bool HasPrev { get; set; }
        public List<Node> Next { get; set; }

        public int CompareTo(Node other)
        {
            return this.Number.CompareTo(other.Number) * -1;
        }
    }
}