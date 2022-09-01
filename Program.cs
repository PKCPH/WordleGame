using WordleGame.Helpers;
using WordleGame.GameExecution;

namespace WordleGame
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose a game to play: \n 1. Wordle, 2. Exit");
            bool menuIsTrue = true;

            while (menuIsTrue)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Wordle wordle = new Wordle();
                        wordle.Game();
                        break;
                    case "2":
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