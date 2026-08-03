/*
1        1
12      21
123    321
1234  4321
1234554321
*/

using System;
using System.Text;
using System.Linq;

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

        StringBuilder numberBuilder = new StringBuilder();

        for (int currentRow = 1; currentRow <= rowCount; currentRow++)
        {
            numberBuilder.Append(currentRow);
            string spaces = new string(' ', (rowCount - currentRow) * 2);
            string reverse = new string(numberBuilder.ToString().Reverse().ToArray());
            Console.WriteLine(numberBuilder + spaces + reverse);
        }
    }
}