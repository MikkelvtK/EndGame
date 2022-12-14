using EndGame.Characters;

namespace EndGame.Interfaces;

public interface IPlayer
{
    public void ChooseAction(BattleSystem battleSystem, Character character);
}