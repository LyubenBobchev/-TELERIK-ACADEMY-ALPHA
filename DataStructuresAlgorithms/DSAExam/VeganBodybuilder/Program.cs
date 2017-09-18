using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace VeganBodybuilder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maximumGrams = int.Parse(Console.ReadLine());
            int numberOfFoods = int.Parse(Console.ReadLine());

            int[,] table = new int[numberOfFoods + 1, maximumGrams + 1];
            List<Food> allFoods = new List<Food>() { null };
            StringBuilder sb = new StringBuilder();

            for (int k = 0; k < numberOfFoods; k++)
            {
                string[] foodProps = Console.ReadLine().Split(' ');

                string foodName = foodProps[0];
                int weight = int.Parse(foodProps[1]);
                int gramsOfProtein = int.Parse(foodProps[2]);

                allFoods.Add(new Food() { Name = foodName, Weight = weight, Protein = gramsOfProtein });
            }

            for (int i = 1; i <= numberOfFoods; i++)
            {
                for (int w = 1; w <= maximumGrams; w++)
                {
                    if (i == 0 || w == 0)
                    {
                        table[i, w] = 0;
                    }
                    else if (allFoods[i].Weight > w)
                    {
                        table[i, w] = table[i - 1, w];
                    }
                    else if (allFoods[i].Weight <= w)
                    {
                        table[i, w] = Math.Max(table[i - 1, w], (allFoods[i].Protein + table[i - 1, w - allFoods[i].Weight]));
                    }
                }
            }

            int items = numberOfFoods;
            int weightF = maximumGrams;
            int maxGramProtein = 0;

            while (items > 0 || weightF > 0)
            {
                if (table[items, weightF] != table[(items - 1), weightF])
                {
                    sb.Append(allFoods[items].Name + "\n");
                    maxGramProtein += allFoods[items].Protein;

                    weightF -= allFoods[items].Weight;
                    items -= 1;
                }
                else
                {
                    items -= 1;
                }

                if (items == 0 || weightF == 0)
                {
                    break;
                }
            }

            Console.WriteLine(maxGramProtein);
            Console.WriteLine(sb);
        }
    }
}

public class Food
{
    public string Name { get; set; }
    public int Weight { get; set; }
    public int Protein { get; set; }
    public bool Chosen { get; set; }
}