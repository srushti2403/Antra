namespace ArraysAndStrings;
using System;

public class Que4
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int k = int.Parse(Console.ReadLine());
        int n = numbers.Length;

        int[] result = new int[n];
        int[] current = new int[n];
        Array.Copy(numbers, current, n);

        for (int r = 1; r <= k; r++)
        {
            int[] rotated = new int[n];

            for (int i = 0; i < n; i++)
            {
                rotated[(i + 1) % n] = current[i];
            }

            for (int i = 0; i < n; i++)
            {
                result[i] += rotated[i];
            }

            current = rotated;
        }

        Console.WriteLine(string.Join(" ", result));
    }
}