using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordleGame.Helpers;

namespace WordleGame.GameExecution
{
    internal class Wordle
    {
        WordFinder wordFinder = new Helpers.WordFinder();

        public void Game()
        {
            //var OxfordDictionariesAPI = new OxfordDictionariesAPI.OxfordDictionaryClient();

            string hiddenWord = wordFinder.GetRandomWord();
            string? guess = null;

            Console.WriteLine($"Guess the word: {hiddenWord}");

            for (int counter = 0; counter < 5; counter++)
            {
                guess = Console.ReadLine().ToUpper();

                //string exceptionString;
                bool isWordNotValid = wordFinder.IsWordNotValid(guess, out var exceptionString);
                if (isWordNotValid)
                {
                    Console.WriteLine(exceptionString);
                    counter = counter - 1;
                }
                else if (guess == hiddenWord)
                {
                    Console.WriteLine($"You guessed correct!");
                    break;
                }
                wordFinder.WordChecker(guess, hiddenWord, counter);

            }


            Console.WriteLine($"The word was {hiddenWord}");
        }
    }
}
