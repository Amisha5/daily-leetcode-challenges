using System;
					
public class Program
{
	public static void Main()
	{
	
		int[] arr = {2, 3, 3, 1, 2};
		reverse(arr, 5);
		Console.WriteLine($"Array reversed");
	}
	public static void reverse(int[] arr, int n)
    {
        if(n==1){
            return;
        }
        Console.WriteLine(arr[n-1]);
        reverse(arr, n-1);
    }
}