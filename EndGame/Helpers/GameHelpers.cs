using EndGame.Characters;

namespace EndGame.Helpers;

public static class GameHelpers
{
    public static Party GetParty(Game game, Character character) 
    {
        return game.Heroes.Members.Contains(character) ? game.Heroes : game.Monsters;
    }

    public static Party GetEnemyParty(Game game, Character character)
    {
        return !game.Heroes.Members.Contains(character) ? game.Heroes : game.Monsters;
    }
}