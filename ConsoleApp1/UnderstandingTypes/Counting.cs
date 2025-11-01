namespace UnderstandingTypes;

public class Counting
{
    public static void Main()
    {
        for (int outer = 1; outer <= 4; outer++)
        {
            for (int inner = 0; inner <= 24; inner += outer)
            {
                Console.Write(inner);
                if (inner + outer <= 24)
                {
                    Console.Write(",");
                }
            }
            
            Console.WriteLine();
        }
    }
}
