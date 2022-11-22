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
            bool gameWinner = false;



            //This section is to print today's word as a test
            for (int i = 0; i < todayWord.Count; i++)
            {
                Console.Write(todayWord[i]);
            }
            Console.WriteLine();
            //End print of todays word.
            gameBoard.printGameBoard();
            while (guessNum <= 5 && !gameWinner)
            {

                Console.Write("Please enter a guess: ");
                playerGuess = Console.ReadLine()!.ToLower();

                while (playerGuess.Length != 5 || String.IsNullOrEmpty(playerGuess) || !File.ReadAllText(fileName).Contains(playerGuess))
                {

                    if (playerGuess.Length != 5 || String.IsNullOrEmpty(playerGuess))
                    {

                        Console.Write("Invalid Guess, please try again: ");
                        playerGuess = Console.ReadLine()!;
                    }
                    else
                    {
                        Console.Write("Word not in word list, please try again: ");
                        playerGuess = Console.ReadLine()!;
                    }

                }


                gameBoard.addGuess(guessNum, playerGuess);
                gameBoard.checkGuess(guessNum, todayWord);
                gameBoard.printGameBoard();


                gameBoard.printScoreBoard();
                Console.WriteLine(gameBoard.checkForWin(guessNum).ToString());
                gameWinner = gameBoard.checkForWin(guessNum);
                guessNum++;


            }

            if (gameWinner)
            {
                Console.WriteLine("Congrats, you win!");

            }
            else
            {
                Console.WriteLine("Sorry, you did not guess the word.  Better luck next time!");
            }




        }




    }
}