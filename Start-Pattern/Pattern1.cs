/*
*****
*****
*****
*****
*****
*/

using System;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.PrintSquarePattern(5);
    }

    public void PrintSquarePattern(int size)
    {
        if (size <= 0) return; // Edge case handling

        // Create the row string once based on the given size
        string asteriskRow = new string('*', size);

        // Print the row 'size' times to form a square
        for (int rowIndex = 0; rowIndex < size; rowIndex++)
        {
            Console.WriteLine(asteriskRow);
        }
    }
}
