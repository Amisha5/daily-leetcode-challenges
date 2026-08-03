using System;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.PrintPattern(3);
    }

    public void PrintPattern(int sideLength)
    {
        if (sideLength <= 0)
        {
            return;
        }

        int gridSize = 2 * sideLength - 1;
        int[,] grid = new int[gridSize, gridSize];

        for (int layer = 0; layer < sideLength; layer++)
        {
            int value = sideLength - layer;
            int startIndex = layer;
            int endIndex = gridSize - 1 - layer;

            for (int row = startIndex; row <= endIndex; row++)
            {
                for (int column = startIndex; column <= endIndex; column++)
                {
                    grid[row, column] = value;
                }
            }
        }

        for (int row = 0; row < gridSize; row++)
        {
            for (int column = 0; column < gridSize; column++)
            {
                Console.Write(grid[row, column]);
            }

            Console.WriteLine();
        }
    }
}