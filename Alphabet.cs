using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consodle
{
    public class Alphabet
    {
        private List<char> gameLetters = new List<char>();

        public Alphabet()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                gameLetters.Add(c);
            }
        }

        public void removeLetter(char letter)
        {
            gameLetters.Remove(letter);

        }

        public void printAvailLetters()
        {
            Console.WriteLine("Available Letters: ");
            foreach (var letter in gameLetters)
            {

                Console.Write(letter + " ");

            }
            Console.WriteLine();
        }
    }



}