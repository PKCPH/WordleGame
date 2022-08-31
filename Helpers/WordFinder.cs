using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordleGame.Helpers
{
    public class WordFinder
    {
        public void WordChecker(string guess, string hiddenWord, int counter)
        {
            Console.CursorLeft = 0;
            //if word is 5 letters
            if (guess.Length != 5) Console.WriteLine("Word is not 5 letter");
            if (!Regex.IsMatch(guess, @"^[a-zA-Z]+$")) Console.WriteLine("Word is not letters from A-Z");
            if (guess == hiddenWord) Console.WriteLine("correct");
            else
            {
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
            }
            Console.ResetColor();
        }

        public string GetRandomWord()
        {
            //System.Diagnostics.Debugger.Launch();
            //var path = GetPathToList();
            var relativePath = Path.GetFullPath(@"..\\..\\..\\Helpers\listofwords.txt");

            ////path to textFile
            //var path = Path.Combine(Directory.GetCurrentDirectory(), @"WordLists\WordListEnglish.txt");

            var lines = File.ReadAllLines(relativePath);


            var r = new Random();
            //random number
            var randomLineNumber = r.Next(0, lines.Length - 1);

            var line = lines[randomLineNumber];

            return line;
        }


        //public static string GetPathToList()
        //{
        //    //current directory passed codecase to getdirectoryname to get info about outputdirectory
        //    var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

        //    //combining pathg with short relative path of textfile path
        //    var iconPath = Path.Combine(outPutDirectory, "C:\\Users\\PatrickKlingaa\\source\\repos\\WordleGame\\Helpers\\listofwords.txt");

        //    var relativePath = Path.GetFullPath("https://raw.githubusercontent.com/PKCPH/WordleGame/master/Helpers/listofwords.txt");
        //    //converting new path to relativer path string with the Uri.LocalPath property.
        //    string icon_path = new Uri(iconPath).AbsolutePath;

        //    return relativePath;
        //}
    }
}


