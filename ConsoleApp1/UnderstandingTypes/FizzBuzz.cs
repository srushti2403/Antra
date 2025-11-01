namespace UnderstandingTypes;

public class FizzBuzz
{
    public static void Main()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 15 == 0)
                Console.WriteLine("FizzBuzz");
            if (i % 3 == 0)
                Console.WriteLine("Fizz");
            if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}