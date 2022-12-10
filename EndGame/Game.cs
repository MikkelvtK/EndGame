using System.Text;
using System.Threading;

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
                    c.DoNothing();
                }
            }
            Console.WriteLine("...");
        }
    }
}
