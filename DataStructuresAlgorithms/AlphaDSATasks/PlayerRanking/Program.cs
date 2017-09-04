using Wintellect.PowerCollections;
using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PlayerRanking
{
    public class Program
    {
        private static readonly BigList<Player> playersRanklist = new BigList<Player>();
        private static readonly Dictionary<string, OrderedSet<Player>> playerByType = new Dictionary<string, OrderedSet<Player>>();

        static void Main()
        {
            Start();
        }

        private static void Start()
        {

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "end")
            {

                switch (command[0])
                {
                    case "add":
                        AddPlayer(command);
                        break;

                    case "find":
                        FindPlayer(command);
                        break;

                    case "ranklist":
                        ShowRankList(command);
                        break;

                }

                command = Console.ReadLine().Split(' ');
            }
        }

        private static void ShowRankList(string[] command)
        {
            int start = int.Parse(command[1]) - 1;
            int counter = start + 1;
            int end = int.Parse(command[2]) - 1;
            int count = end - start + 1;
            var rankedPlayers = playersRanklist.Range(start, count);

            Console.WriteLine(string.Join("; ", rankedPlayers.Select(x => string.Format("{0}. {1}", counter++, x.ToString()))));
        }

        private static void FindPlayer(string[] command)
        {
            var playerType = command[1];

            if (playerByType.ContainsKey(playerType))
            {
                Console.WriteLine(string.Format("Type {0}: {1}", playerType, string.Join("; ", playerByType[playerType].Take(5))));
            }
            else
            {
                string.Format("Type {0}: ", playerType);
            }
        }

        private static void AddPlayer(string[] command)
        {
            string name = command[1];
            string type = command[2];
            int age = int.Parse(command[3]);
            int position = int.Parse(command[4]) - 1;

            Player player = new Player(name, type, age, position);

            if (!playerByType.ContainsKey(command[2]))
            {
                playerByType.Add(command[2], new OrderedSet<Player>());
            }

            playerByType[type].Add(player);
            playerByType.Where(x => x.Value == null);
            playersRanklist.Insert(position, player);

            string[] b = new string[9999999999999999999];

            Console.WriteLine("Added player {0} to position {1}", player.Name, player.Position + 1);
        }
    }


    public class Player : IComparable<Player>
    {
        private readonly string name;
        private readonly string type;
        private readonly int age;
        private int position;

        public Player(string name, string playerType, int age, int position)
        {
            this.name = name;

            this.type = playerType;

            this.age = age;

            this.Position = position;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public int Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }

        public int CompareTo(Player other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age) * -1;
            }

            return result;

        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Age);
        }
    }
}




