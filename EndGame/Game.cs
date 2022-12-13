using EndGame.Characters;

namespace EndGame;

public class Game
{
    public Party Heroes;
    public Party Monsters;

    public Game(Party heroes, Party monsters)
    {
        Heroes = heroes;
        Monsters = monsters;
    }

    public void Run()
    {
        while (Heroes.Alive && Monsters.Alive)
        {
            foreach (Party p in new[] { Heroes, Monsters })
            {
                p.UpdateParty();

                foreach (Character c in p.Members)
                {
                    Console.WriteLine();
                    Console.WriteLine($"It is {c.Name}'s turn...");
                    Thread.Sleep(500);
                    p.Player.ChooseAction(this, c);
                }
            }
            Console.WriteLine("...");
        }

        DisplayWinner();
    }

    private void DisplayWinner()
    {
        if (Heroes.Alive)
        {
            Console.WriteLine("The Heroes have won, and the Uncoded One is defeated!");
        }
        else
        {
            Console.WriteLine("The Monsters have won, and the Uncoded One's forces have prevailed.");
        }
    }
}
