using WordleGame.Helpers;

namespace WordleGame
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose a game to play: \n 1. Wordle");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Guess the word: ");

                    Wordle wordleGame = new Wordle();
                    wordleGame.Game();

                    break;
                default:
                    break;
            }



            Console.ReadKey();
        }
    }

}