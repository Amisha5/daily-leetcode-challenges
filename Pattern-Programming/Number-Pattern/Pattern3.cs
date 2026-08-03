/*
12345
1234
123
12
1
*/

using System;
using System.Text;

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

        StringBuilder numberPattern = new StringBuilder();

        for (int currentNumber = 1; currentNumber <= rowCount; currentNumber++)
        {
            numberPattern.Append(currentNumber);
        }

        for (int currentRow = rowCount; currentRow >= 1; currentRow--)
        {
            Console.WriteLine(numberPattern.ToString());
            numberPattern.Length--;
        }
    }
}