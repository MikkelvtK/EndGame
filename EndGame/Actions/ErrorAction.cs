using EndGame.Interfaces;

namespace EndGame.Actions;

public class ErrorAction : IAction
{
    public string Name { get; set; }

    public ErrorAction()
    {
        Name = "Error";
    }

    public void Execute()
    {
        Console.WriteLine("Something went wrong chosing an action");
    }
}