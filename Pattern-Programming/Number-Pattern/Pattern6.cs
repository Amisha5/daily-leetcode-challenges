/*
1
2  3
4  5   6
7  8   9 10
11 12 13 14 15
*/

using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.PrintPatternApproachOne(5);
        program.PrintPatternApproachTwo(5);
    }

    public void PrintPatternApproachOne(int rowCount)
    {
        if (rowCount <= 0)
        {
            return;
        }

        StringBuilder numberBuilder = new StringBuilder();
        int nextNumber = 1;

        for (int currentRow = 1; currentRow <= rowCount; currentRow++)
        {
            numberBuilder.Clear();

            for (int currentColumn = 0; currentColumn < currentRow; currentColumn++)
            {
                numberBuilder.Append(nextNumber++).Append(' ');
            }

            Console.WriteLine(numberBuilder.ToString().TrimEnd());
        }
    }

    public void PrintPatternApproachTwo(int rowCount)
    {
        if (rowCount <= 0)
        {
            return;
        }

        int totalNumbers = rowCount * (rowCount + 1) / 2;
        int rowLength = 1;
        int countInRow = 0;

        for (int currentNumber = 1; currentNumber <= totalNumbers; currentNumber++)
        {
            Console.Write(currentNumber + " ");
            countInRow++;

            if (countInRow == rowLength)
            {
                Console.WriteLine();
                rowLength++;
                countInRow = 0;
            }
        }
    }
}