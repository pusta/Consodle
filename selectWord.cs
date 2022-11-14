using System;
using System.IO;

namespace Consodle
{
    public class selectWord
    {
                string fileName = @"wordlist.txt";
        private string selectedWord = string.Empty;
        

        public selectWord ()
        {
            selectedWord = string.Empty;
        }

        public string getWord()
        {
            int lineCount = File.ReadAllLines(fileName).Length;
            Random rnd = new Random();
            int lineNum = rnd.Next(lineCount);


            return selectedWord;

        }
    }
}