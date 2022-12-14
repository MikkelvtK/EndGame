using EndGame.Interfaces;

namespace EndGame.Actions;

public class DoNothingAction : IAction
{
    private readonly string CharacterName;
    public string Name { get; set; }

    public DoNothingAction(string characterName)
    {
        CharacterName = characterName;
        Name = "Do Nothing";
    }

    public void Execute()
    {
        Console.WriteLine($"{CharacterName} did NOTHING.");
    }
}