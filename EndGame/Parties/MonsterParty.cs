using EndGame.Characters;
using EndGame.Interfaces;

namespace EndGame.Parties
{
    public class MonsterParty : Party
    {
        public MonsterParty(IPlayer player, int numberOfSkeletons) : base(player)
        {
            for (int i = 0; i < numberOfSkeletons; i++)
            {
                Members.Add(new Skeleton());
            }
        }
    }
}