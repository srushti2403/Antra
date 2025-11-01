namespace ArraysAndStrings;
using System;

public class LongestSequence
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int bestStart = 0;
        int bestLength = 1;

        int currentStart = 0;
        int currentLength = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentLength++;
            }
            else
            {
                currentStart = i;
                currentLength = 1;
            }

            if (currentLength > bestLength)
            {
                bestLength = currentLength;
                bestStart = currentStart - currentLength + 1 + (currentStart != 0 ? 0 : 0);
                bestStart = currentStart - currentLength + 1;
            }
        }

        for (int i = bestStart; i < bestStart + bestLength; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}