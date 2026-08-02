/*
*****
****
***
**
*
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

        for (int currentRow = rowCount; currentRow >= 0; currentRow--)
        {
            string row = new string('*', currentRow);
            Console.WriteLine(row);
        }
    }
}