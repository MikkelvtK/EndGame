
using EndGame.Characters;
using EndGame.Parties;

public class BattleSystem
{
    public Party Heroes { get; }
    public Party Monsters { get; set; }
    private List<Party> _monstersQueue;

    public BattleSystem(Party heroes, List<Party> monsters)
    {
        _monstersQueue = monsters;
        Heroes = heroes;

        NextBattle();
    }

    public bool NextBattle()
    {
        if (_monstersQueue.Count == 0) return false;

        Monsters = _monstersQueue.First();
        _monstersQueue.Remove(Monsters);
        return true;
    }

    public Party GetParty(Character character) 
    {
        return Heroes.Members.Contains(character) ? Heroes : Monsters;
    }

    public Party GetEnemyParty(Character character)
    {
        return !Heroes.Members.Contains(character) ? Heroes : Monsters;
    }
}
