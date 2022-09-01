using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSpell;

namespace WordleGame.GameExecution
{
    internal class WordSmith
    {
        public void Game()
        {
            char[] rngChar = GetEightRandomCharacter();

            Console.WriteLine(rngChar);
        }

        public static char[] GetEightRandomCharacter()
        {
            var text = "qwertyuiopasdfghjklzxcvbnm";
            var rng = new Random();

            int index = rng.Next(text.Length);
            char[] characterArray = new char[7];
            characterArray[0] = (char)index;
            characterArray[1] = (char)index;
            characterArray[2] = (char)index;
            characterArray[3] = (char)index;
            characterArray[4] = (char)index;
            characterArray[5] = (char)index;
            characterArray[6] = (char)index;
            return characterArray;
        }
    }
}
