namespace ArraysAndStrings;
using System;
using System.Text.RegularExpressions;

public class AllPalindromes
{
    public static void Main()
    {
        string input = Console.ReadLine();

        // Split text into tokens by non-alphanumeric characters
        string[] tokens = Regex.Split(input, @"[^A-Za-z0-9]+")
            .Where(t => t.Length > 0)
            .ToArray();

        HashSet<string> palindromes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (string word in tokens)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        // Sort by lowercase representation for case-insensitive ordering
        var sorted = palindromes.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);

        Console.WriteLine(string.Join(", ", sorted));
    }

    static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (char.ToLower(word[left]) != char.ToLower(word[right]))
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}