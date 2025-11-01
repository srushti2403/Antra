namespace ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Text;

public class ReverseWords
{
    public static void Main()
    {
        string input = Console.ReadLine();

        char[] separators = 
        {
            '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"',
            '\'', '\\', '/', '!', '?', ' '
        };

        List<string> words = new List<string>();
        List<string> separatorsList = new List<string>();

        StringBuilder current = new StringBuilder();
        bool readingWord = !IsSeparator(input[0], separators);

        for (int i = 0; i < input.Length; i++)
        {
            if (IsSeparator(input[i], separators))
            {
                if (readingWord)
                {
                    words.Add(current.ToString());
                    current.Clear();
                }
                current.Append(input[i]);
                readingWord = false;
            }
            else
            {
                if (!readingWord)
                {
                    separatorsList.Add(current.ToString());
                    current.Clear();
                }
                current.Append(input[i]);
                readingWord = true;
            }
        }

        if (readingWord) words.Add(current.ToString());
        else separatorsList.Add(current.ToString());

        words.Reverse();

        // Reconstruct sentence
        int w = 0, s = 0;
        StringBuilder output = new StringBuilder();
        bool expectWord = true;

        for (int i = 0; i < words.Count + separatorsList.Count; i++)
        {
            if (expectWord) output.Append(words[w++]);
            else output.Append(separatorsList[s++]);
            expectWord = !expectWord;
        }

        Console.WriteLine(output.ToString());
    }

    static bool IsSeparator(char c, char[] sep)
    {
        foreach (char x in sep)
        {
            if (c == x) return true;
        }
        return false;
    }
}
