using EndGame.Actions;
using EndGame.Attacks;

namespace EndGame.Characters;

public class TrueProgrammer : Character
{
    public TrueProgrammer(string username) : base(username, 25)
    {
        Actions.Add(new DoNothingAction(Name));
        Actions.Add(new AttackAction(new Punch(), Name));
    }
} 