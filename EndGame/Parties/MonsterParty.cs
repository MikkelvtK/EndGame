using EndGame.Characters;
using EndGame.Interfaces;

namespace EndGame.Parties
{
    public class MonsterParty : Party
    {
        public MonsterParty(IPlayer player, int numberOfSkeletons, bool uncodedOne = false) : 
            base(player)
        {
            for (int i = 0; i < numberOfSkeletons; i++)
            {
                Members.Add(new Skeleton());
            }

            if (uncodedOne) Members.Add(new UncodedOne());
        }
    }
}