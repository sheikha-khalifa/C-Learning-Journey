namespace Homework_1___Week_3
{
    internal class Program
    {

            static int mazeSize = 7; //  the maze size 
            static char[,] maze;
            static int playerRow;
            static int playerCol;
            static int exitRow;
            static int exitCol;
            static bool gameWon;
            static DateTime startTime;

        static void InitializeMaze()
        {
            maze = new char[mazeSize, mazeSize];

            playerRow = 1;
            playerCol = 1;
            exitRow = mazeSize - 2;
            exitCol = mazeSize - 2;
            gameWon = false;
            startTime = DateTime.Now;
        }

        static void DisplayMaze()
        {
            Console.Clear();
            for (int i = 0; i < mazeSize; i++)
            {
                for (int j = 0; j < mazeSize; j++)
                {
                    if (i == playerRow && j == playerCol)
                        Console.Write("S "); // Player
                    else if (i == exitRow && j == exitCol)
                        Console.Write("E "); // Exit
                    else if (maze[i, j] == '#')
                        Console.Write("# "); // Wall
                    else
                        Console.Write("# "); // Empty space
                }
                Console.WriteLine();
            }
        }

        static void MovePlayer(char direction)
        {
            int newPlayerRow = playerRow;
            int newPlayerCol = playerCol;

            // Calculate new position based on player input
            switch (direction)
            {
                case 'U':
                    newPlayerRow--;
                    break;
                case 'D':
                    newPlayerRow++;
                    break;
                case 'L':
                    newPlayerCol--;
                    break;
                case 'R':
                    newPlayerCol++;
                    break;
                default:
                    return;
            }

            // Check if the new position is valid
            if (IsValidMove(newPlayerRow, newPlayerCol))
            {
                playerRow = newPlayerRow;
                playerCol = newPlayerCol;
                if (playerRow == exitRow && playerCol == exitCol)
                    gameWon = true;
            }
        }

        static bool IsValidMove(int row, int col)
        {
            return row >= 0 && row < mazeSize && col >= 0 && col < mazeSize && maze[row, col] != '#';
        }
        static void Main()
        {
            InitializeMaze();
            DisplayMaze();

            while (!gameWon)
            {
                Console.WriteLine("Enter your move (U/L/D/R): ");
                char move = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                MovePlayer(move);
                DisplayMaze();
            }

            TimeSpan timeTaken = DateTime.Now - startTime;
            Console.WriteLine($"Congratulations! You've reached the Exit in {timeTaken.TotalSeconds} seconds!");
            Console.WriteLine("Do you want to play again? (Y/N): ");
            char playAgain = Char.ToUpper(Console.ReadKey().KeyChar);
            if (playAgain == 'Y')
            {
                Main();
            }
            else
            {
                Console.WriteLine("\n Thank you for playing the Maze Escape Challenge!");
            }
        }
       
        }
    }
