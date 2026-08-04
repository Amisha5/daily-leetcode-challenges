using System;

public class Program
{
    public static void Main()
    {
        int gcdOne = GetGcd(9, 12);
        Console.WriteLine($"EdgeCase One -> {gcdOne}");

        int gcdTwo = GetGcd(20, 15);
        Console.WriteLine($"EdgeCase Two -> {gcdTwo}");
    }

    public static int GetGcd(int firstNumber, int secondNumber)
    {
        if (firstNumber == 0 && secondNumber == 0)
        {
            return 0;
        }

        int greatestCommonDivisor = 0;
        int limit = Math.Min(firstNumber, secondNumber);

        for (int currentNumber = 1; currentNumber <= limit; currentNumber++)
        {
            if (firstNumber % currentNumber == 0 && secondNumber % currentNumber == 0)
            {
                greatestCommonDivisor = currentNumber;
            }
        }

        return greatestCommonDivisor;
    }
}