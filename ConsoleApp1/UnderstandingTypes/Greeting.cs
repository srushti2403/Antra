namespace UnderstandingTypes;

public class Greeting
{
    public static void Main()
    {
        DateTime current = DateTime.Now; // use real time when confident

        int hour = current.Hour;

        if (hour >= 5 && hour < 12)
            Console.WriteLine("Good Morning");

        if (hour >= 12 && hour < 17)
            Console.WriteLine("Good Afternoon");

        if (hour >= 17 && hour < 21)
            Console.WriteLine("Good Evening");

        if (hour >= 21 || hour < 5)
            Console.WriteLine("Good Night");
    }

}