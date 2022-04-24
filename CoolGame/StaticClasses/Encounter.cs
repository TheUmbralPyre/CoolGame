using System;
using System.Collections.Generic;
using System.Linq;
using CoolGame.Interfaces.CharacterInterfaces;

namespace CoolGame
{
    public class Encounter
    {
        private int turnNumber = 1;

        ICharacter characterOne;
        ICharacter characterTwo;

        public Encounter(ICharacter characterOne, ICharacter characterTwo)
        {
            this.characterOne = characterOne;
            this.characterTwo = characterTwo;
        }

        /// <summary>
        /// Handle a Fight between two Characters.
        /// </summary>
        public void Fight()
        {
            while (characterOne.Health.CurrentValue > 0 || characterTwo.Health.CurrentValue > 0)
            {
                // Handle the First Character Dealing Damage to the Second One
                Attack(characterOne, characterTwo);

                // Handle the First Character Dealing Damage to the Second One
                Attack(characterTwo, characterOne);

                AdvanceTurn();
            }
        }

        private void AdvanceTurn()
        {
            turnNumber += 1;
        }

        /// <summary>
        /// The Attacker Deals Damage to the Target and their Stats are Displayed.
        /// </summary>
        /// <param name="attacker"> The Attacking Character. </param>
        /// <param name="target"> The Target of the Attack. </param>
        private void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine($"TURN {turnNumber} {{{attacker.Name}}}");

            // Make the Atttacker Deal Damage to the Target
            attacker.DealDamage(target);

            // Get the Stats of Both Characters
            Console.WriteLine();
            Console.WriteLine($"END OF TURN {turnNumber}");
            /// Add Stats Here
            /// Also Make Speed Matter
            Console.WriteLine("/////////////////////////////////");

            Console.WriteLine();
        }
    }
}
