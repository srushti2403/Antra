namespace ArraysAndStrings;

public class ManageList
{
    public static void Main()
    {
        List<string> items = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                continue;

            input = input.Trim();

            if (input.StartsWith("+"))
            {
                string item = input.Substring(1).Trim();
                if (item.Length > 0)
                {
                    items.Add(item);
                    Console.WriteLine($"Added: {item}");
                }
            }

            if (input.StartsWith("-") && input != "--")
            {
                string item = input.Substring(1).Trim();
                if (items.Remove(item))
                {
                    Console.WriteLine($"Removed: {item}");
                }
                else
                {
                    Console.WriteLine($"Item not found: {item}");
                }
            }

            if (input == "--")
            {
                items.Clear();
                Console.WriteLine("List cleared");
            }

            Console.WriteLine("Current list:");
            if (items.Count == 0)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                foreach (string item in items)
                {
                    Console.WriteLine("- " + item);
                }
            }

            Console.WriteLine();
        }
    }
}