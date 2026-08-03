/*
1
01
101
0101
10101
*/

using System;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.PrintPattern(5);
    }

    public void PrintPattern(int rowCount)
    {
        if (rowCount <= 0)
        {
            return;
        }

        for (int currentRow = 1; currentRow <= rowCount; currentRow++)
        {
            for (int currentColumn = 0; currentColumn < currentRow; currentColumn++)
            {
                if ((currentRow + currentColumn) % 2 == 0)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write("1");
                }
            }

            Console.WriteLine();
        }
    }
}