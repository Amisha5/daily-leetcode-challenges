using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> divisorsOfThirtySix = GetDivisors(36);
        Console.WriteLine($"EdgeCase One -> {string.Join(", ", divisorsOfThirtySix)}");

        List<int> divisorsOfTwenty = GetDivisors(8);
        Console.WriteLine($"EdgeCase Two -> {string.Join(", ", divisorsOfTwenty)}");
    }

    public static List<int> GetDivisors(int number)
    {
        List<int> divisors = new List<int>();

        for (int currentNumber = 1; currentNumber <= number; currentNumber++)
        {
            if (number % currentNumber == 0)
            {
                divisors.Add(currentNumber);
            }
        }

        return divisors;
    }
}