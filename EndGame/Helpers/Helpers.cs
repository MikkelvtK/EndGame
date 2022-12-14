using Microsoft.Win32.SafeHandles;

namespace EndGame.Helpers;

public static class Helpers
{
    public static string GetName()
    {
        Console.Write("What is your username? ");
        string username = Console.ReadLine();
        if (username == null) throw new Exception("Something went wrong with the username.");

        return username;
    }
}