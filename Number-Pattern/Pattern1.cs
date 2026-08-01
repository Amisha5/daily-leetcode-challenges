/*
1
12
123
1234
12345
*/

using System;
using System.Text;

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
            st.Append(i.ToString());
            Console.WriteLine(numberPattern);
        }
    }
}