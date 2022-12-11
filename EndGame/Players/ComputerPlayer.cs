using EndGame.Interfaces;
using EndGame.Characters;
using System.Collections.Generic;
using EndGame.Actions;

namespace EndGame.Players;

public class ComputerPlayer : IPlayer
{
    public IAction ChooseAction(Character character)
    {
        foreach (IAction a in character.Actions)
        {
            if (a.GetType() == typeof(DoNothingAction))
            {
                return a;
            }
        }

        return new ErrorAction();
    }
}