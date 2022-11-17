// See https://aka.ms/new-console-template for more information
using System.IO;

namespace Consodle
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int guessNum = 0;
            string playerGuess;
            string fileName = @"wordlist.txt";
            selectWord selectedWord = new selectWord();
            var todayWord = selectedWord.getWord();
            gameArray gameBoard = new gameArray();


            Console.WriteLine(todayWord);
            //gameBoard.printGameBoard();
            while (guessNum <= 5)
            {

                Console.Write("Please enter a guess: ");
                playerGuess = Console.ReadLine()!.ToLower();

                while (playerGuess.Length != 5 || String.IsNullOrEmpty(playerGuess) || !File.ReadAllText(fileName).Contains(playerGuess))
                {
                    Console.Write("Invalid Guess, please try again:");
                    playerGuess = Console.ReadLine()!;
                }


                gameBoard.addGuess(guessNum, playerGuess);
                gameBoard.printGameBoard();
                guessNum++;


            }



        }


    }
}