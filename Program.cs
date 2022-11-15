// See https://aka.ms/new-console-template for more information

namespace Consodle
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            selectWord selectedWord = new selectWord();
            var todayWord = selectedWord.getWord();
            gameArray gameBoard = new gameArray();


            Console.WriteLine(todayWord);
            gameBoard.printGameBoard();


        }


    }
}