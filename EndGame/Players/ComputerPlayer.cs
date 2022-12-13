using EndGame.Interfaces;
using EndGame.Characters;
using EndGame.Helpers;

namespace EndGame.Players;

public class ComputerPlayer : IPlayer
{
    public void ChooseAction(Game game, Character character)
    {
        Character enemy = GameHelpers.GetEnemyParty(game, character).Members[0];
        character.StandardAttack.Attack.SetAttackParameters(character, enemy);
        character.StandardAttack.Execute();
    }
}