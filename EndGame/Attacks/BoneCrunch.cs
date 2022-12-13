namespace EndGame.Attacks
{
    public class BoneCrunch : Attack
    {
        public BoneCrunch() : base("BONE CRUNCH") {}

        public override int GetDamage()
        {
            var random = new Random();
            return random.Next(2);
        }
    }
}