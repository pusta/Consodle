namespace Consodle
{
    public class gameArray
    {

        private string[,] gameBoard = new string[6, 5];
        private string[,] scoreBoard = new string[6, 5];
        private List<string> todayWord;

        Alphabet gameLetters = new Alphabet();

        selectWord selectedWord = new selectWord();

        public gameArray()
        {

            int uBound0 = gameBoard.GetUpperBound(0);
            int uBound1 = gameBoard.GetUpperBound(1);

            for (int i = 0; i <= uBound0; i++)
            {
                for (int j = 0; j <= uBound1; j++)
                {
                    gameBoard[i, j] = "_";
                    scoreBoard[i, j] = "_";

                }
            }

            todayWord = selectedWord.getWord();




        }

        public void clearArray()
        {
            Array.Clear(gameBoard, 0, gameBoard.Length);
            Array.Clear(scoreBoard, 0, scoreBoard.Length);


        }

        public void addGuess(int guessNum, string playerGuess)
        {
            playerGuess = playerGuess.ToUpper();

            for (int i = 0; i < 5; i++)
            {
                gameBoard[guessNum, i] = playerGuess[i].ToString();

            }


        }

        /*public void checkGuess(int guessNum)
        {
            for (int i = 0; i < 5; i++)
            {
                //counts the number of times a letter occurs in the word.
                var letterOccurance = todayWord.Count(x => x == gameBoard[guessNum, i]);

                if (gameBoard[guessNum, i] == todayWord[i])
                {
                    scoreBoard[guessNum, i] = "C";

                }
                else if (todayWord.Contains(gameBoard[guessNum, i]))
                {
                    scoreBoard[guessNum, i] = "*";

                }

                else
                {
                    scoreBoard[guessNum, i] = "I";
                    gameLetters.removeLetter(Char.Parse(gameBoard[guessNum, i]));
                }

            }*/

        public void checkGuess(int guessNum)
        {
            bool letterFound = false;

            for (int i = 0; i < 5; i++)
            {
                //counts the number of times a letter occurs in the word.
                var letterOccurance = todayWord.Count(x => x == gameBoard[guessNum, i]);
                

                if(letterOccurance == 0)
                {
                    scoreBoard[guessNum, i] = "I";
                    gameLetters.removeLetter(Char.Parse(gameBoard[guessNum, i]));
                }

                else
                {
                    if (gameBoard[guessNum, i] == todayWord[i])
                    {
                        scoreBoard[guessNum, i] = "C";
                        if (letterOccurance == 1)
                        {
                            letterFound = true;
                        }

                    }
                    else if (todayWord.Contains(gameBoard[guessNum, i]) && letterFound == false)
                    {
                        scoreBoard[guessNum, i] = "*";
                    }

                }
                

            }


        }

        public bool checkForWin(int guessNum)
        {
            int numCorrect = 0;
            for (int i = 0; i < 5; i++)
            {
                if (scoreBoard[guessNum, i] == "C")
                {
                    numCorrect = numCorrect + 1;
                }

            }

            if (numCorrect == 5)
            {
                return true;
            }
            else
            {
                return false;
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
                    switch (scoreBoard[i, j])
                    {
                        case "C":
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case "*":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case "I":
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                    }

                    string res = gameBoard[i, j];
                    Console.Write(res);
                    Console.ResetColor();
                }
                Console.WriteLine();

            }
            gameLetters.printAvailLetters();
        }

        public void printScoreBoard()
        {
            int uBound0 = scoreBoard.GetUpperBound(0);
            int uBound1 = scoreBoard.GetUpperBound(1);

            for (int i = 0; i <= uBound0; i++)
            {
                for (int j = 0; j <= uBound1; j++)
                {
                    string res = scoreBoard[i, j];
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }

        public void printTodayWord()
        {


            //This section is to print today's word as a test
            for (int i = 0; i < todayWord.Count; i++)
            {
                Console.Write(todayWord[i]);
            }
            Console.WriteLine();
            //End print of todays word.


        }


    }
}