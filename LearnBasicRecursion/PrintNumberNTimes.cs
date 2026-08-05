using System;

public class Program
{
    public static void Main()
    {
        PrintNumbers(5);
    }

    public static void PrintNumbers(int n, int count = 1)
    {
        if (count > n)
        {
            return;
        }

        Console.WriteLine(count);
        PrintNumbers(n, count + 1);
    }
}