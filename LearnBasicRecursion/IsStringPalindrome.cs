using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string value1 = "A man, a plan, a canal: Panama";
        bool isPalindromeRecursive1 = PalindromeCheck(value1);
        bool isPalindromeIterative1 = IsPalindrome(value1);
        Console.WriteLine($"Recursive: Is '{value1}' a palindrome? {isPalindromeRecursive1}");
        Console.WriteLine($"Iterative: Is '{value1}' a palindrome? {isPalindromeIterative1}");

        string value2 = "race a car";
        bool isPalindromeRecursive2 = PalindromeCheck(value2);
        bool isPalindromeIterative2 = IsPalindrome(value2);
        Console.WriteLine($"Recursive: Is '{value2}' a palindrome? {isPalindromeRecursive2}");
        Console.WriteLine($"Iterative: Is '{value2}' a palindrome? {isPalindromeIterative2}");
    }

    public static bool PalindromeCheck(string s, int left = 0, int right = -1)
    {
        if (string.IsNullOrEmpty(s))
        {
            return true;
        }

        if (right == -1)
        {
            s = Regex.Replace(s, "[^a-zA-Z0-9]", string.Empty).ToLowerInvariant();
            right = s.Length - 1;
        }

        if (left >= right)
        {
            return true;
        }

        if (s[left] != s[right])
        {
            return false;
        }

        return PalindromeCheck(s, left + 1, right - 1);
    }

    // Approach 2: iterative palindrome check without recursion
    // 1. Normalize the string by removing non-alphanumeric characters
    // 2. Convert all characters to lowercase for case-insensitive comparison
    // 3. Compare characters with two pointers moving inward
    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length == 1)
        {
            return true;
        }

        s = new string(
            s.Where(char.IsLetterOrDigit)
             .Select(char.ToLowerInvariant)
             .ToArray()
        );

        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}

