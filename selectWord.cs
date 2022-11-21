using System;
using System.IO;
using System.Collections.Generic;

namespace Consodle
{
    public class selectWord
    {
        string fileName = @"wordlist.txt";
        private string selectedWord;
        private List<string> todayWord = new List<string>();


        public selectWord()
        {
            selectedWord = string.Empty;
        }

        public List<string> getWord()
        {
            int lineCount = File.ReadAllLines(fileName).Length;
            Random rnd = new Random();
            int lineNum = rnd.Next(lineCount);

            selectedWord = File.ReadLines(fileName).ElementAtOrDefault(lineNum - 1)!;
            for (int i = 0; i < 5; i++)
            {
                todayWord.Add(selectedWord[i].ToString().ToUpper());
            }

            return todayWord;



        }
    }
}