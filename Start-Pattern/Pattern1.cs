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
        Program p = new Program();
        p.pattern1(5);
    }

    public void pattern1(int n) 
    {
        if (n <= 0) return; // Edge case handling

        // Create the row string once: "*****"
        string row = new string('*', n);
        
        // Print the row n times
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(row);
        }
    }
}