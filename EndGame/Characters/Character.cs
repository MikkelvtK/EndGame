using EndGame.Actions;
using EndGame.Attacks;
using EndGame.Interfaces;

namespace EndGame.Characters;

public abstract class Character
{
    public string Name { get; }
    public List<IAction> Actions { get; } = new List<IAction>();
    public AttackAction StandardAttack { get; }

    public Character(string name, Attack attack)
    {
        Name = name;
        StandardAttack = new AttackAction(attack);
    }
}
