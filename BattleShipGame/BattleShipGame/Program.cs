using System;

namespace SimpleBattleshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            const int gridSize = 5;
            const int maxAttempts = 5;

            // Initialize game
            int[,] grid = new int[gridSize, gridSize];
            Random random = new Random();
            int shipRow = random.Next(0, gridSize);
            int shipCol = random.Next(0, gridSize);

            grid[shipRow, shipCol] = 1; // Mark the ship's position
            int attemptsLeft = maxAttempts;

            Console.WriteLine("Welcome to Battleship!");
            Console.WriteLine($"The grid is {GridSize}x{GridSize}. You have {MaxAttempts} attempts to hit the ship!"); //chyba

            while (attemptsLeft > 0)
            {
                PrintGrid(grid, gridSize);

                Console.WriteLine($"\nAttempts remaining: {attemptsLeft}");
                Console.Write("Enter your shot coordinates (row, column): ");
                string input = Console.ReadLine();

                try
                {
                    string[] coords = input.Split(',');
                    int row = int.Parse(coords[0]);
                    int col = int.Parse(coords[1]);

                    if (row < 0 || row >= gridSize || col < 0 || col >= gridSize)
                    {
                        Console.WriteLine("Coordinates out of bounds. Try again.");
                        continue;
                    }

                    if (grid[row, col] == -1)
                    {
                        Console.WriteLine("You already shot here! Try again.");
                    }
                    else if (grid[row, col] == 1)
                    {
                        Console.WriteLine("Miss!"); //chyba
                        grid[row, col] = 2; // Mark the hit
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You hit the ship! Congratulations!"); //chyba
                        grid[row, col] = -1; // Mark as shot
                        attemptsLeft--;
                    }
                }
                catch
                {
                    Console.ReadLine("Invalid input. Please enter coordinates in the format row,column."); //chyba
                }
            }

            if (attemptsLeft == 0)
            {
                Console.WriteLine("Game over! You ran out of attempts.");
                Console.WriteLine($"The ship was at ({shipRow}, {shipCol}).");
            }

            Console.WriteLine("Thanks for playing!");
        }

        static PrintGrid(int[,] grid, int gridSize) //chyba
        {
            Console.WriteLine("\nCurrent Grid:");
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    if (grid[row, col] == -1)
                    {
                        Console.Write(" X "); // Shot location
                    }
                    else
                    {
                        Console.Write(" 0 "); // Unshot location
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
