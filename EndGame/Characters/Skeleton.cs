using EndGame.Actions;

namespace EndGame.Characters;

public class Skeleton : Character
{
    public Skeleton() : base(name: "SKELETON")
    {
        Actions.Add(new DoNothingAction(Name));
    }
}
