namespace Consodle
{
    public class gameArray
    {

        private string[,] gameBoard = new string[6, 5];
        public gameArray()
        {

            int uBound0 = gameBoard.GetUpperBound(0);
            int uBound1 = gameBoard.GetUpperBound(1);

            for (int i = 0; i <= uBound0; i++)
            {
                for (int j = 0; j <= uBound1; j++)
                {
                    gameBoard[i, j] = "_";

                }
            }



        }

        public void clearArray()
        {
            Array.Clear(gameBoard, 0, gameBoard.Length);


        }

        public void addGuess(int guessNum, string playerGuess)
        {
            playerGuess = playerGuess.ToUpper();

            for (int i = 0; i < 5; i++)
            {
                gameBoard[guessNum, i] = playerGuess[i].ToString();

            }


        }

        public void printGameBoard()
        {
            int uBound0 = gameBoard.GetUpperBound(0);
            int uBound1 = gameBoard.GetUpperBound(1);

            for (int i = 0; i <= uBound0; i++)
            {
                for (int j = 0; j <= uBound1; j++)
                {
                    string res = gameBoard[i, j];
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }


    }
}