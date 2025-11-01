namespace ArraysAndStrings;

public class FrequentNumber
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Dictionary<int, int> freq = new Dictionary<int, int>();
        Dictionary<int, int> firstIndex = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int num = numbers[i];

            if (!freq.ContainsKey(num))
            {
                freq[num] = 0;
                firstIndex[num] = i;
            }

            freq[num]++;
        }

        int mostFrequent = numbers[0];
        int maxFreq = freq[mostFrequent];
        int leftmostIndex = firstIndex[mostFrequent];

        foreach (var kvp in freq)
        {
            int num = kvp.Key;
            int count = kvp.Value;

            if (count > maxFreq ||
                (count == maxFreq && firstIndex[num] < leftmostIndex))
            {
                mostFrequent = num;
                maxFreq = count;
                leftmostIndex = firstIndex[num];
            }
        }

        Console.WriteLine($"The number {mostFrequent} is the most frequent (occurs {maxFreq} times)");
    }
}