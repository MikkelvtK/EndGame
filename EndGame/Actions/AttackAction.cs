using EndGame.Attacks;
using EndGame.Characters;
using EndGame.Interfaces;

namespace EndGame.Actions
{
    public class AttackAction : IAction
    {
        private readonly Attack _attack;
        private readonly string _attackerName;
        private Character Target { get; set; }

        public AttackAction(Attack attack, string attackerName)
        {
            _attack = attack;
            _attackerName = attackerName;
        }

        public AttackAction SetAttackParameters(Character target)
        {
            Target = target;
            return this;
        }

        public void Execute()
        {
            int damage = _attack.GetDamage();
            Target.CurrentHealth -= damage;

            Console.WriteLine($"{_attackerName} used {_attack.Name} on {Target.Name}.");
            Console.WriteLine($"{_attack.Name} dealt {damage} damage to {Target.Name}.");
            Console.WriteLine($"{Target.Name} is now at {Target.CurrentHealth}/{Target.MaxHealth}.");
        }
    }
}