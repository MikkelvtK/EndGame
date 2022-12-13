using EndGame.Attacks;
using EndGame.Interfaces;

namespace EndGame.Actions
{
    public class AttackAction : IAction
    {
        public Attack Attack { get; }

        public AttackAction(Attack attack)
        {
            Attack = attack;   
        }

        public void Execute()
        {
            Console.WriteLine($"{Attack.Attacker.Name} used {Attack.Name} on {Attack.Target.Name}.");
        }
    }
}