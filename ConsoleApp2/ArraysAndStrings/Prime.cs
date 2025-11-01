namespace ArraysAndStrings;

public class Prime
{
    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();

        for (int number = Math.Max(startNum, 2); number <= endNum; number++)
        {
            if (IsPrime(number))
            {
                primes.Add(number);
            }
        }

        return primes.ToArray();
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        int boundary = (int)Math.Sqrt(num);

        for (int i = 3; i <= boundary; i += 2)
        {
            if (num % i == 0) return false;
        }

        return true;
    }
}