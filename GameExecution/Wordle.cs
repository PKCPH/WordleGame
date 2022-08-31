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

            for (int counter = 0; counter < 5; counter++)
            {
                guess = Console.ReadLine();
                wordFinder.WordChecker(guess, hiddenWord, counter);
            }


             Console.WriteLine($"The word was {hiddenWord}");
        }
    }
}
