using EndGame.Interfaces;

namespace EndGame.Characters;

public abstract class Character
{
    public string Name { get; }
    public int MaxHealth { get; set; }
    private int _currentHealth;
    public int CurrentHealth 
    { 
        get => _currentHealth; 
        set => _currentHealth = Math.Clamp(value, 0, MaxHealth); 
    }
    public List<IAction> Actions { get; } = new List<IAction>();

    public Character(string name, int maxHealth)
    {
        Name = name;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
    }
}
