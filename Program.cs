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

            gameArray gameBoard = new gameArray();
            bool gameWinner = false;


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
                gameBoard.checkGuess(guessNum);
                gameBoard.printGameBoard();

                //Prints the scoreboard array, which keeps track of correct and incorrect guesses.  Debugging only.
                //gameBoard.printScoreBoard();

                //Prints the current status of the game.  True means player has won, false keeps going.  Debugging only 
                //Console.WriteLine(gameBoard.checkForWin(guessNum).ToString());
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