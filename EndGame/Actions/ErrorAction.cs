using EndGame.Interfaces;

namespace EndGame.Actions;

public class ErrorAction : IAction
{
    public void Execute()
    {
        Console.WriteLine("Something went wrong chosing an action");
    }
}