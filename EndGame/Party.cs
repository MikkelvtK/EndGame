using System.Linq.Expressions;
using EndGame.Characters;
using EndGame.Interfaces;

namespace EndGame;

public class Party
{
    public List<Character> Members { get; }
    public bool Alive { get; set; }
    public IPlayer Player { get; }

    public Party(IPlayer player)
    {
        Player = player;
        Alive = true;
        Members = new List<Character>();
    }

    public void UpdateParty()
    {
        Character deadMember = Members.Find(x => x.CurrentHealth == 0);

        if (deadMember != null)
        {
            Console.WriteLine($"{deadMember.Name} has been defeated!");
            Members.Remove(deadMember);
            if (Members.Count == 0) Alive = false;
        }
    }
}
