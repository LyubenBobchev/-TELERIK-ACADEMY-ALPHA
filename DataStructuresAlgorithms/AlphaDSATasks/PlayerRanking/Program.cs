using Wintellect.PowerCollections;
using System.Linq;
using System;
using System.Collections;

namespace PlayerRanking
{
    public class Program
    {
        static void Main()
        {
            BigList<Player> players = new BigList<Player>();

            string[] commandInput = Console.ReadLine().Split(' ');

            while (commandInput[0] != "end")
            {

                switch (commandInput[0])
                {
                    case "add":
                        Commands.AddPlayer(commandInput, players);
                        break;

                    case "find":
                        Commands.FindPlayer(commandInput, players);
                        break;

                    case "ranklist":
                        Commands.ShowRankList(commandInput, players);
                        break;

                }

                commandInput = Console.ReadLine().Split(' ');
            }
        }
    }

    public class Player
    {
        private readonly string name;
        private readonly string playerType;
        private readonly int age;
        private int position;

        public Player(string name, string playerType, int age, int position)
        {
            if (name.Length < 1 || name.Length > 20)
            {
                throw new ArgumentOutOfRangeException("Invalid string length!");
            }
            this.name = name;

            if (playerType.Length < 1 || playerType.Length > 10)
            {
                throw new ArgumentOutOfRangeException("Invalid string length!");
            }
            this.playerType = playerType;

            if (age < 10 || age > 50)
            {
                throw new ArgumentOutOfRangeException("Invalid player age!");
            }
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

        public string PlayerType
        {
            get
            {
                return this.playerType;
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

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Age);
        }
    }

    public static class Commands
    {
        public static void AddPlayer(string[] addCommand, BigList<Player> playerList)
        {


            Player player = new Player(addCommand[1], addCommand[2], int.Parse(addCommand[3]), int.Parse(addCommand[4]));

            playerList.Insert((player.Position - 1), player);

            Console.WriteLine("Added player {0} to position {1}", player.Name, player.Position);
        }

        public static void FindPlayer(string[] findCommand, BigList<Player> playerList)
        {
            Console.WriteLine("Type {0}: {1}", findCommand[1], ((playerList.Count != 0 ? string.Join("; ",
                playerList
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Age)
                .Where(x => x.PlayerType == findCommand[1]).Take(5)) : "")));
        }

        public static void ShowRankList(string[] rankListCommand, BigList<Player> playerList)
        {
            int counter = 1;
            Console.WriteLine(string.Join("; ", playerList.Take(int.Parse(rankListCommand[2])).Select(x => string.Format("{0}. {1}", counter++, x))));
        }
    }
}
