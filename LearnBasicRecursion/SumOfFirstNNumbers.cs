using System;

public class Program
{
    public static void Main()
    {
        int sum = SumOfFirstNNumbers(5);
        Console.WriteLine(sum);
    }

    public static int SumOfFirstNNumbers(int n)
    {
        if (n <= 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        return n + SumOfFirstNNumbers(n - 1);
    }

}