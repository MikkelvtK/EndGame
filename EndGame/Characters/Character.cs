using EndGame.Actions;
using EndGame.Attacks;
using EndGame.Interfaces;

namespace EndGame.Characters;

public abstract class Character
{
    public string Name { get; }
    public int MaxHealth { get; set; }
    public int CurrentHealth { get; set; }
    public List<IAction> Actions { get; } = new List<IAction>();

    public Character(string name, int maxHealth)
    {
        Name = name;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
    }
}
