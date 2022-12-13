using EndGame.Actions;
using EndGame.Attacks;

namespace EndGame.Characters;

public class Skeleton : Character
{
    public Skeleton() : base(name: "SKELETON", 5)
    {
        Actions.Add(new DoNothingAction(Name));
        Actions.Add(new AttackAction(new BoneCrunch(), Name));
    }
}
