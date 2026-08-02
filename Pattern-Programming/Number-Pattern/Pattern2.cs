/*
1
22
333
4444
55555
*/
using System;
using System.Text;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Program p = new Program();
        p.pattern1(5);
    }

    public void pattern1(int n)
    {
        StringBuilder numberPattern = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            sb.Clear();
            sb.AppendJoin("", Enumerable.Repeat(i.ToString(), i));
            Console.WriteLine(numberPattern);
        }
    }
}