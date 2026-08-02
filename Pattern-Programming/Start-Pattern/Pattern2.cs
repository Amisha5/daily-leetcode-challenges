/*
*
**
***
****
*****
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
            string row = new string('*', currentRow);
            Console.WriteLine(row);
        }
    }
}