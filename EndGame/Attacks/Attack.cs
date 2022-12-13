using EndGame.Characters;

namespace EndGame.Attacks
{
    public abstract class Attack
    {
        public string Name { get; }

        public Attack(string name)
        {
            Name = name;
        }

        public abstract int GetDamage();
    }
}