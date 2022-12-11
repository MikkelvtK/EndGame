using System.Collections.Generic;
using EndGame.Characters;
using EndGame.Interfaces;

namespace EndGame;

public class Party
{
    public List<Character> Members { get; } = new();
    public IPlayer Player { get; }

    public Party(IPlayer player)
    {
        Player = player;
    }
}
