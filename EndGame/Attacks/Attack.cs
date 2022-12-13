using EndGame.Characters;

namespace EndGame.Attacks
{
    public class Attack
    {
        public string Name { get; }
        public Character Attacker { get; set; }
        public Character Target { get; set; }

        public Attack(string name)
        {
            Name = name;
        }

        public void SetAttackParameters(Character attacker, Character target)
        {
            Attacker = attacker;
            Target = target;
        }
    }
}