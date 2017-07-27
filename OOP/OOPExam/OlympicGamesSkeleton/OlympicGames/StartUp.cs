using OlympicGames.Core.Factories;
using OlympicGames.Olympics.Enums;

namespace OlympicGames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // Don not touch here (Magic Unicorns)
            // Engine.Instance.Run();

            System.Console.WriteLine(OlympicsFactory.Instance.CreateBoxer("Wladimir", " Klitschko", "Ukraine", "heavyweight", 64, 5).ToString());
        }
    }
}
