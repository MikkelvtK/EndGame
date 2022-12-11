using System.Collections.Generic;
using EndGame.Interfaces;

namespace EndGame.Characters;

public abstract class Character
{
    public string Name { get; }
    public List<IAction> Actions { get; } = new List<IAction>();

    public Character(string name)
    {
        Name = name;
    }
}
