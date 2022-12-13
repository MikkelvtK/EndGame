using EndGame.Interfaces;
using EndGame.Characters;
using EndGame.Helpers;
using EndGame.Actions;

namespace EndGame.Players;

public class ComputerPlayer : IPlayer
{
    public void ChooseAction(Game game, Character character)
    {
        foreach (IAction action in character.Actions)
        {
            if (action.GetType() == typeof(AttackAction))
            {
                var attackAction = (AttackAction)action;
                Character enemy = GameHelpers.GetEnemyParty(game, character).Members[0];
                attackAction.SetAttackParameters(enemy).Execute();
            }
        }
    }
}