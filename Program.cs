using WordleGame.Helpers;
using WordleGame.GameExecution;

namespace WordleGame
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose a game to play: \n 1. Wordle, 2. coming soon..");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Guess the word: ");

                    Wordle wordle = new Wordle();
                    wordle.Game();

                    break;
                case "2":

                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}