namespace UnderstandingTypes;

public class RandomNumber
{
    public static void Main()
    {
        Random random = new Random();
        int secret = random.Next(1, 4);
        
        Console.Write("Guess a number between 1 and 3: ");
        int guessNumber = int.Parse(Console.ReadLine()!);

        if (guessNumber < 1 || guessNumber > 3)
        {
            Console.WriteLine("Your guess is outside the valid range.");
        }
        else if (guessNumber == secret)
        {
            Console.WriteLine("Correct! You guessed the number!");
        }
        else if (guessNumber < secret)
        {
            Console.WriteLine("Too low!");
        }
        else
        {
            Console.WriteLine("Too high!");
        }
    }
}