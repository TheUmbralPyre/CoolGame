using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGame
{
    static internal class Combat
    {
        /// <summary>
        /// Handle a Fight between two Characters.
        /// </summary>
        /// <param name="characterOne"> The First Character. </param>
        /// <param name="characterTwo"> The Secodn Character. </param>
        static public void Fight(ICharacter characterOne, ICharacter characterTwo)
        {
            // Handle the First Character Dealing Damage to the Second One
            characterOne.DealDamage(characterTwo);

            Console.WriteLine();

            // Handle the Second Character Dealing Damage to the First One
            characterTwo.DealDamage(characterOne);
        }
    }
}
