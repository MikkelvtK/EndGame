using System.Collections.Generic;
using EndGame.Interfaces;

namespace EndGame.Actions;

public class DoNothingAction : IAction
{
    private readonly string CharacterName;

    public DoNothingAction(string characterName)
    {
        CharacterName = characterName;
    }

    public void Execute()
    {
        Console.WriteLine($"{CharacterName} did NOTHING.");
    }
}