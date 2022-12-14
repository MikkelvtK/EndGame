using EndGame.Interfaces;
using EndGame.Characters;
using EndGame.Actions;

namespace EndGame.Players;

public class ComputerPlayer : IPlayer
{
    public void ChooseAction(BattleSystem battleSystem, Character character)
    {
        foreach (IAction action in character.Actions)
        {
            if (action.GetType() == typeof(AttackAction))
            {
                var attackAction = (AttackAction)action;
                Character enemy = battleSystem.GetEnemyParty(character).Members[0];
                attackAction.SetAttackParameters(enemy).Execute();
            }
        }
    }
}