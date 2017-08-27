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
        private static readonly Dictionary<PlayerType, OrderedSet<Player>> playerByType = new Dictionary<PlayerType, OrderedSet<Player>>();

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
            throw new NotImplementedException();
        }

        private static void FindPlayer(string[] command)
        {
            throw new NotImplementedException();
        }

        private static void AddPlayer(string[] command)
        {
            Player player = new Player(command[1], command[2], int.Parse(command[3]), int.Parse(command[4]));

            if (!playerByType.ContainsKey(type))
            {
                playerByType.Add(type, new OrderedSet<Player>());
            }

            playerByType[type].Add(player);

            playersRanklist.Insert((player.Position - 1), player);

            Console.WriteLine("Added player {0} to position {1}", player.Name, player.Position);
        }
    }

    public enum PlayerType
    {
        Aggressive,
        Neutral,
        Defensive
    }

    public class Player : IComparable<Player>
    {
        private readonly string name;
        private readonly PlayerType type;
        private readonly int age;
        private int position;

        public Player(string name, PlayerType playerType, int age, int position)
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

        public PlayerType Type
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




