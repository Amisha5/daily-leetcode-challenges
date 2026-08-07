using System;

public class Program
{
    public static void Main()
    {
        int number = 10;

        int bruteForceResult = FibonacciBruteForce(number);
        int recursiveResult = FibonacciRecursive(number);

        Console.WriteLine($"Brute force result: Fibonacci({number}) = {bruteForceResult}");
        Console.WriteLine($"Recursive result: Fibonacci({number}) = {recursiveResult}");
    }

    // Approach 1: Brute force / iterative solution
    public static int FibonacciBruteForce(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        int previous = 0;
        int current = 1;

        for (int i = 2; i <= n; i++)
        {
            int next = previous + current;
            previous = current;
            current = next;
        }

        return current;
    }

    // Approach 2: Recursive solution
    public static int FibonacciRecursive(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
}