using EndGame.Actions;
using EndGame.Attacks;

namespace EndGame.Characters
{
    public class UncodedOne : Character
    {
        public UncodedOne() : base("THE UNCODED ONE", 15)
        {
            Actions.Add(new AttackAction(new Unraveling(), Name));
        }
    }
}