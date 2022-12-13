using EndGame.Actions;
using EndGame.Attacks;

namespace EndGame.Characters;

public class TrueProgrammer : Character
{
    public TrueProgrammer(string username) : base(username, new Punch())
    {
        Actions.Add(new DoNothingAction(Name));
    }
} 