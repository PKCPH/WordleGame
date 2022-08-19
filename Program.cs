using WordleGame.Helpers;

namespace WordleGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the word: ");

            WordleHelpers wordleGame = new WordleHelpers();
            wordleGame.Game();

            Console.ReadKey();
        }
    }

}