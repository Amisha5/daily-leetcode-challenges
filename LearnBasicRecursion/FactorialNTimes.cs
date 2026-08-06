using System;

public class Program
{
    public static void Main()
    {
        int number = 5;
        int factorial = Factorial(number);
        Console.WriteLine($"Factorial of {number} is {factorial}");
    }

    public static int Factorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }
}