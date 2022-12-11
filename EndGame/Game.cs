using System.Text;
using System.Threading;
using EndGame.Characters;

namespace EndGame;

public class Game
{
    private Party Heroes;
    private Party Monsters;

    public Game(Party heroes, Party monsters)
    {
        Heroes = heroes;
        Monsters = monsters;
    }

    public void Run()
    {
        while (true)
        {
            foreach (Party p in new[] { Heroes, Monsters })
            {
                foreach (Character c in p.Members)
                {
                    Console.WriteLine();
                    Console.WriteLine($"It is {c.Name}'s turn...");
                    Thread.Sleep(500);
                    p.Player.ChooseAction(c).Execute();
                }
            }
            Console.WriteLine("...");
        }
    }
}
