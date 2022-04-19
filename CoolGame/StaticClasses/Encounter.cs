using System;
using System.Collections.Generic;
using System.Linq;
using CoolGame.Interfaces.CharacterInterfaces;

namespace CoolGame
{
    internal class Encounter
    {
        int turnNumber = 1;

        int turnAttacker = 0;

        int turnDefender = 1;
        ///

        List<ICharacter> turnQueue;

        public Encounter(List<ICharacter> characters)
        {
            turnQueue = characters.OrderByDescending(x => x.Speed).ToList();
        }

        /// <summary>
        /// Handle a Fight between two Characters.
        /// </summary>
        public void Fight()
        {
            while (!turnQueue.Exists(x => x.Health <= 0))
            {
                Console.WriteLine("/////////////////////////////////");
                Console.WriteLine($"TURN {turnNumber} {{{turnQueue[turnAttacker].Name}}}");
                // Handle the First Character Dealing Damage to the Second One
                Attack(turnQueue[turnAttacker], turnQueue[turnDefender]);

                AdvanceTurn();
            }
        }

        private void AdvanceTurn()
        {
            turnNumber += 1;

            //turnAttacker = turnAttacker == 1 ? 0 : 1;

            //turnDefender = turnDefender == 0 ? 1 : 0;

            var tempChar = turnQueue[0];
            turnQueue.RemoveAt(0);
            turnQueue.Add(tempChar);
        }

        /// <summary>
        /// The Attacker Attacks the Target Dealing Damage and their Stats are Displayed.
        /// </summary>
        /// <param name="attacker"> The Attacking Character. </param>
        /// <param name="target"> The Target of the Attack. </param>
        private void Attack(ICharacter attacker, ICharacter target)
        {
            // Make the Atttacker Deal Damage to the Target
            attacker.DealDamage(target);

            // Get the Stats of Both Characters
            Console.WriteLine();
            Console.WriteLine($"END OF TURN {turnNumber}");
            Console.WriteLine("/////////////////////////////////");

            Console.WriteLine();
        }
    }
}
