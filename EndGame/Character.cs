
namespace EndGame;

public abstract class Character
{
    public string Name { get; }

    public Character(string name)
    {
        Name = name;
    }

    public void DoNothing()
    {
        Console.WriteLine($"{Name} did NOTHING.");
    }
}
