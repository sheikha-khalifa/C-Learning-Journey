namespace MazeGame
{
 
    public class MazeGame
    {
        private char[,] maze; // Represents the maze grid.
        private int playerX; 
        private int playerY; 

        public MazeGame(char[,] mazeGrid)
        {
            maze = mazeGrid;
            playerX = -1;
            playerY = -1;
        }

        
        public void StartGame()
        {
            FindStartingPoint();
            if (playerX == -1 || playerY == -1)
            {
                Console.WriteLine("Starting point not found in the maze.");
                return;
            }
              while (true)
            {
                DisplayMaze();
                Console.WriteLine("Enter your move (U - Up, L - Left, D - Down, R - Right):");
                char move = Console.ReadKey().KeyChar;

               if (!MovePlayer(move))
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
                if (maze[playerX, playerY] == 'E')
                {
                    Console.WriteLine("Congratulations! You have reached the exit.");
                    break;
                }
            }
        }

        private void FindStartingPoint()
        {
            int rows = maze.GetLength(0);
            int columns = maze.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (maze[i, j] == 'S')
                    {
                        playerX = i;
                        playerY = j;
                        return;
                    }
                }
            }
        }

        public bool MovePlayer(char move)
        {
            int newX = playerX;
            int newY = playerY;

            switch (move)
            {
                case 'U':
                    newX--;
                    break;
                case 'L':
                    newY--;
                    break;
                case 'D':
                    newX++;
                    break;
                case 'R':
                    newY++;
                    break;
                default:
                    return false;
            }

            if (newX >= 0 && newX < maze.GetLength(0) && newY >= 0 && newY < maze.GetLength(1) && maze[newX, newY] != '#')
            {
                playerX = newX;
                playerY = newY;
                return true;
            }

            return false;
        }

        public void DisplayMaze()
        {
            int rows = maze.GetLength(0);
            int columns = maze.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == playerX && j == playerY)
                    {
                        Console.Write("P "); // Player position.
                    }
                    else
                    {
                        Console.Write(maze[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public class Program
        {
            public static void Main()
            {
                // Define the maze grid.
                char[,] mazeGrid = {
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
            { '#', 'S', '.', '.', '#', '.', '.', '.', '.', '#' },
            { '#', '.', '#', '.', '#', '.', '#', '#', '.', '#' },
            { '#', '.', '#', '.', '#', '.', '#', '#', '.', '#' },
            { '#', '.', '#', '#', '#', '.', '#', '#', '.', '#' },
            { '#', '.', '.', '.', '.', '.', '.', '.', '.', '#' },
            { '#', '#', '#', '#', '#', '#', '#', '#', 'E', '#' },
        };

               MazeGame mazeGame = new MazeGame(mazeGrid);

                // Start the maze game.
                mazeGame.StartGame();
              // mazeGame.MovePlayer();

            }
        }
    }
}