using EndGame.Characters;
using EndGame.Parties;

public class Game
{
    private readonly BattleSystem _battleSystem;

    public Game(BattleSystem battleSystem)
    {
        _battleSystem = battleSystem;
    }

    public void Run()
    {
        while (_battleSystem.Heroes.Alive && _battleSystem.Monsters.Alive)
        {
            foreach (Party p in new[] { _battleSystem.Heroes, _battleSystem.Monsters })
            {
                foreach (Character c in p.Members)
                {
                    Console.WriteLine();
                    Console.WriteLine($"It is {c.Name}'s turn...");
                    Thread.Sleep(500);
                    p.Player.ChooseAction(_battleSystem, c);
                    _battleSystem.GetEnemyParty(c).UpdateParty();

                    if (!_battleSystem.Monsters.Alive) _battleSystem.NextBattle();
                }
            }
            Console.WriteLine("...");
        }

        DisplayWinner();
    }

    private void DisplayWinner()
    {
        if (_battleSystem.Heroes.Alive)
        {
            Console.WriteLine("The Heroes have won, and the Uncoded One is defeated!");
        }
        else
        {
            Console.WriteLine("The Monsters have won, and the Uncoded One's forces have prevailed.");
        }
    }

    private void BuildMenu(Character character)
    {
        
    }
}
