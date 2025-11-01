namespace UnderstandingTypes;

public class Pyramid
{
    public static void Main()
    {
        int totalLines = 5;

        for (int line = 1; line <= totalLines; line++)
        {
            for (int s = 0; s < totalLines - line; s++)
            {
                Console.Write(" ");
            }

            for (int star = 0; star < (2 * line) - 1; star++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
    }
}