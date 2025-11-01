namespace UnderstandingTypes;

public class Birthdate
{
    public static void Main()
    {
        DateTime birthDate = new DateTime(1998, 03, 24); 

        DateTime today = DateTime.Today;

        TimeSpan ageSpan = today - birthDate;
        int totalDays = ageSpan.Days;

        Console.WriteLine($"You are {totalDays} days old.");

        int daysToNextAnniversary = 10000 - (totalDays % 10000);
        DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);

        Console.WriteLine($"Your next 10,000 day anniversary is on: {nextAnniversary:yyyy-MM-dd}");
        Console.WriteLine($"That is in {daysToNextAnniversary} days.");
    }
}