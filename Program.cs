using WordleGame.Helpers;
using WordleGame.GameExecution;

namespace WordleGame
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose a game to play1: \n 1. Wordle, 2. WordSmith 3. Exit Application (not a game lol...)");
            bool menuIsTrue = true;

            while (menuIsTrue)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Wordle wordle = new();
                        wordle.Game();
                        break;
                    case "2":
                        WordSmith wordSmith = new();
                        wordSmith.Game();
                        break;
                    case "3":
                        menuIsTrue = false;
                        break;
                    default:
                        menuIsTrue = true;
                        break;
                }
            }
        }
    }
}