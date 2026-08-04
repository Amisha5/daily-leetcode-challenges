using System;

public class Program
{
    public static void Main()
    {
        bool isPrimeFive = IsPrime(5);
        Console.WriteLine($"Prime Check for 5 -> {isPrimeFive}");

        bool isPrimeEight = IsPrime(8);
        Console.WriteLine($"Prime Check for 8 -> {isPrimeEight}");

        bool isPrimeNine = IsPrime(9);
        Console.WriteLine($"Prime Check for 9 -> {isPrimeNine}");
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int currentNumber = 2; currentNumber <= number - 1; currentNumber++)
        {
            if (number % currentNumber == 0)
            {
                return false;
            }
        }

        return true;
    }
}