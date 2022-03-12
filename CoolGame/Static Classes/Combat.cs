using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGame
{
    static internal class Combat
    {
        static public void Fight(ICharacter warriorOne, ICharacter warriorTwo)
        {
            warriorOne.DealDamage(warriorTwo);

            Console.WriteLine();

            warriorTwo.DealDamage(warriorOne);
        }
    }
}
