using EndGame.Characters;

namespace EndGame.Interfaces;

public interface IPlayer
{
    public void ChooseAction(Game game, Character character);
}