namespace ArraysAndStrings;

public class ParseURL
{
    public static void Main()
    {
        string url = Console.ReadLine();

        string protocol = "";
        string server = "";
        string resource = "";

        string working = url;

        int protocolIndex = working.IndexOf("://");
        if (protocolIndex != -1)
        {
            protocol = working.Substring(0, protocolIndex);
            working = working.Substring(protocolIndex + 3);
        }

        int slashIndex = working.IndexOf("/");
        if (slashIndex != -1)
        {
            server = working.Substring(0, slashIndex);
            resource = working.Substring(slashIndex + 1);
        }
        else
        {
            server = working;
        }

        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
    }
}