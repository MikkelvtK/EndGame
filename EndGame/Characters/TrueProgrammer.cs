using EndGame.Actions;

namespace EndGame.Characters;

public class TrueProgrammer : Character
{
    public TrueProgrammer(string username) : base(username)
    {
        Actions.Add(new DoNothingAction(Name));
    }
} 