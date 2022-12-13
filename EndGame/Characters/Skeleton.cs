using EndGame.Actions;
using EndGame.Attacks;

namespace EndGame.Characters;

public class Skeleton : Character
{
    public Skeleton() : base(name: "SKELETON", new BoneCrunch())
    {
        Actions.Add(new DoNothingAction(Name));
    }
}
