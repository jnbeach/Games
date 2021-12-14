using System;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Let's Play Connect 4!");
            Console.WriteLine("---------------------------------------");
            Connect4 game = new Connect4();
            int move = 1;
            Console.WriteLine("Type a column number (1-7) to make a move. 0 to exit the game.");
            while (move != 0)
            {
                move = int.Parse(Console.ReadLine());
                if (move > 0 && move <= 7)
                {
                    game.play(move - 1);
                }
            }
            Console.WriteLine("You have exited the game. Thanks for playing!");
        }
    }
    class Connect4
    {
        public byte PlayerTurn { get; private set; }
        private int[,] gameBoard;
        public bool PlayerHasWon { get; private set; }
        public Connect4()
        {
            this.PlayerTurn = 1;
            this.gameBoard = new int[6, 7];
            for (int i = 0; i <= gameBoard.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= gameBoard.GetUpperBound(1); j++)
                {
                    this.gameBoard[i, j] = 0;
                }
            }
            displayBoard();
            Console.WriteLine($"Player one goes first!");
        }
        public string play(int col)
        {
            //If a player has already won, return game has finished.
            if (PlayerHasWon)
            {
                Console.WriteLine($"Game has finished!");
                return "Game has finished!";
            }
            //Check if the column is full. If so, returns a message.
            if (this.gameBoard[0, col] != 0)
            {
                Console.WriteLine($"Column full! Try a different move!");
                return "Column full!";
            }
            Console.WriteLine($"Player {this.PlayerTurn} moved a piece into column {col + 1}.");
            //Go to the bottom row and check if the space is occupied, then go row by row up from there. If a piece is placed, exit the for loop.
            for (int i = gameBoard.GetUpperBound(0); i >= 0; i--)
            {
                if (this.gameBoard[i, col] == 0)
                {
                    this.gameBoard[i, col] = this.PlayerTurn;
                    break;
                }
            }
            displayBoard();
            //Check if there is a win after a move
            winChecker();
            if (PlayerHasWon)
            {
                Console.WriteLine($"Player {PlayerTurn} wins!");
                return $"Player {PlayerTurn} wins!";
            }
            switchTurn();
            Console.WriteLine($"It is now Player {this.PlayerTurn}'s Turn!");
            return $"Player {this.PlayerTurn} has a turn";
        }
        public void displayBoard()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.Write($"Col:    1  2  3  4  5  6  7");
            for (int i = 0; i < gameBoard.GetUpperBound(0) + 1; i++) //Rows
            {
                Console.Write($"\nRow {i + 1}:  ");
                for (int j = 0; j < gameBoard.GetUpperBound(1) + 1; j++)//Columns
                {
                    if (this.gameBoard[i, j] == 0)
                    {
                        Console.Write("*  ");
                    }
                    else if (gameBoard[i, j] == 1)
                    {
                        Console.Write("X  ");
                    }
                    else
                    {
                        Console.Write("O  ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("---------------------------------------");
        }
        public void switchTurn()
        {
            if (this.PlayerTurn == 1)
            {
                this.PlayerTurn = 2;
            }
            else
            {
                this.PlayerTurn = 1;
            }
        }
        public void winChecker()
        {
            //Starts from the bottom row and moves left to right.
            int player;
            bool isWin = false;
            for (int i = gameBoard.GetUpperBound(0); i >= 0; i--)
            {
                for (int j = 0; j <= 3; j++)//Only need to go to the 4th column.
                {
                    //Checks if there is a win in a row.
                    if (gameBoard[i, j] > 0)
                    {
                        player = gameBoard[i, j];
                        isWin = player == gameBoard[i, j + 1] && player == gameBoard[i, j + 2] && player == gameBoard[i, j + 3];
                        if (isWin)
                        {
                            this.PlayerHasWon = true;
                        }
                    }
                    //Checks if there is a win in a column
                    if (gameBoard[i, j] > 0 && i >= 3)
                    {
                        player = gameBoard[i, j];
                        isWin = player == gameBoard[i - 1, j] && player == gameBoard[i - 2, j] && player == gameBoard[i - 3, j];
                        if (isWin)
                        {
                            this.PlayerHasWon = true;
                        }
                    }
                    //Checks if there is a win on a diagonal that goes to the top right
                    if (gameBoard[i, j] > 0 && i >= 3 && j <= 3)
                    {
                        player = gameBoard[i, j];
                        isWin = player == gameBoard[i - 1, j + 1] && player == gameBoard[i - 2, j + 2] && player == gameBoard[i - 3, j + 3];
                        if (isWin)
                        {
                            this.PlayerHasWon = true;
                        }
                    }
                    //Checks if there is a win on a diagonal that goes to the top left
                    if (gameBoard[i, j] > 0 && i >= 3 && j >= 3)
                    {
                        player = gameBoard[i, j];
                        isWin = player == gameBoard[i - 1, j - 1] && player == gameBoard[i - 2, j - 2] && player == gameBoard[i - 3, j - 3];
                        if (isWin)
                        {
                            this.PlayerHasWon = true;
                        }
                    }
                }
            }
        }
    }
}
