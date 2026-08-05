using System;

public class Program
{
    public static void Main()
    {
        PrintNameNTimes("Amisha Patidar", 5);
    }

    public static void PrintNameNTimes(string name, int count)
    {
        if (count <= 0)
        {
            return;
        }

        Console.WriteLine(name);
        PrintNameNTimes(name, count - 1);
    }
}