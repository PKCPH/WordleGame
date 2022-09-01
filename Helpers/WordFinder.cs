using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using NetSpell.SpellChecker;


namespace WordleGame.Helpers
{
    public class WordFinder
    {
        public bool IsWordNotValid(string guess, out string exceptionString)
        {
            if (guess.Length != 5) {
                exceptionString = "Word must only be 5 letter"; 
                return true; }

            if (!Regex.IsMatch(guess, @"^[a-zA-Z]+$"))
            {
                exceptionString = "Your guess needs to be a valid word with letters from A-Z";
                return true;
            }
            if (!IsWordInDictionary(guess)) { exceptionString = "Word is not in dictionary"; return true; }


            else exceptionString = "";  return false;


        }

        public bool IsWordInDictionary(string guess)
        {
            Spelling spelling = new Spelling();

            bool isWordTrue = spelling.Dictionary.Equals(guess);

            if (isWordTrue) return true;
            else return false;
        }

        public void WordChecker(string guess, string hiddenWord, int counter)
        {
            Console.CursorLeft = 0;

            for (int i = 0; i < hiddenWord.Length; i++)
            {
                if (hiddenWord[i] == guess[i])
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(guess[i]);
                }
                else if (hiddenWord.Contains(guess[i]))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write(guess[i]);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(guess[i]);
                }
            }
            Console.WriteLine();

            Console.ResetColor();
        }

        public string GetRandomWord()
        {

            var relativePath = Path.GetFullPath(@"..\\..\\..\\Helpers\listofwords.txt");
            var lines = File.ReadAllLines(relativePath);

            var r = new Random();
            var randomLineNumber = r.Next(0, lines.Length - 1);

            var line = lines[randomLineNumber];

            return line.ToUpper();
        }
    }
}


