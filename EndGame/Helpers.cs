namespace EndGame;

public static class Helpers
{
    public static string GetName()
    {
        Console.Write("What is your username? ");
        string? username = Console.ReadLine();
        if (username == null) return "";
        return username;
    }
}