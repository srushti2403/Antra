namespace ConsoleApp3;

public class Methods1
{
    public static void Main()
    {
        int[] numbers = GenerateNumbers();  
        Reverse(numbers);
        PrintNumbers(numbers);
    }
    
    static int[] GenerateNumbers()
    {
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }
        return arr;
    }
    
    static void Reverse(int[] array)
    {
        int length = array.Length;

        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }

    static void PrintNumbers(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}