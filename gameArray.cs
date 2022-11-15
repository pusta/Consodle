namespace Consodle
{
    public class gameArray
    {

        private string[,] gameBoard = new string[6, 5];
        public gameArray()
        {

        }

        public void clearArray()
        {
            Array.Clear(gameBoard, 0, gameBoard.Length);


        }
    }
}