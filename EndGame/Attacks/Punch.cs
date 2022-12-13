namespace EndGame.Attacks;

public class Punch : Attack
{
    public Punch() : base("PUNCH") {}

    public override int GetDamage()
    {
        return 1;
    }
}