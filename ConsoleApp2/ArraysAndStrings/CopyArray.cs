// See https://aka.ms/new-console-template for more information

int[] original = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

// create a new array with the same length
int[] copy = new int[original.Length];

// copy elements manually using a loop
for (int i = 0; i < original.Length; i++)
{
    copy[i] = original[i];
}

// print both arrays to verify
Console.WriteLine("Original array:");
for (int i = 0; i < original.Length; i++)
{
    Console.Write(original[i] + " ");
}

Console.WriteLine("\nCopied array:");
for (int i = 0; i < copy.Length; i++)
{
    Console.Write(copy[i] + " ");
}

Console.WriteLine();