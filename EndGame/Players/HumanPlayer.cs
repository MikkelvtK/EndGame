using EndGame.Actions;
using EndGame.Characters;
using EndGame.Interfaces;

namespace EndGame.Players
{
    public class HumanPlayer : IPlayer
    {
        public void ChooseAction(BattleSystem battleSystem, Character character)
        {
            bool makingChoice = true;

            while (makingChoice)
            {
                for (int i = 0; i < character.Actions.Count; i++)
                {
                    IAction action = character.Actions[i];
                    Console.WriteLine($"{i} - Standard Attack({action.Name})");
                }

                Console.Write("What do you want to do? ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input >= 0 && input < character.Actions.Count)
                {
                    PerformAction(character.Actions[input], battleSystem, character);
                    makingChoice = false;
                }
            }            
        }

        private void PerformAction(IAction action, BattleSystem battleSystem, Character character)
        {
            if (action.GetType() == typeof(AttackAction))
            {
                var attackAction = (AttackAction)action;
                Character enemy = battleSystem.GetEnemyParty(character).Members[0];
                attackAction.SetAttackParameters(enemy).Execute();
            }
        }
    }
}