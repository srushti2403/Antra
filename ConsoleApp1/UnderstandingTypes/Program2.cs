namespace UnderstandingTypes;

public class Program2
{
    public static void Main()
    {
        Console.Write("Enter the number of centuries: ");
        int centuries = int.Parse(Console.ReadLine()!);

        int years = centuries * 100;
        
        decimal daysDecimal = years * 365.242m;
        ulong days = (ulong)daysDecimal;
        
        ulong hours = days * 24;
        ulong minutes = hours * 60;
        ulong seconds = minutes * 60;
        ulong milliseconds = seconds * 1000;
        ulong microseconds = milliseconds * 1000;
        ulong nanoseconds = microseconds * 1000;
        
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}