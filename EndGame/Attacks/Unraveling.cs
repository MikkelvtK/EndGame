namespace EndGame.Attacks
{
    public class Unraveling : Attack
    {
        public Unraveling() : base("UNRAVELING") {}

        public override int GetDamage()
        {
            var random = new Random();
            return random.Next(3);
        }
    }
}