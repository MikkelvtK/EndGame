using EndGame.Characters;

namespace EndGame.Interfaces;

public interface IPlayer
{
    public IAction ChooseAction(Character character);
}