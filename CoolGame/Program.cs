using System.Collections.Generic;
using CoolGame.Classes.CharacterClasses;
using CoolGame.Interfaces.CharacterInterfaces;

namespace CoolGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var warror = new Berserker("Rolf", 1, 20, 1, 1);
            var wawror = new Reaver("Aureus", 4, 10 ,1.5, 0);

            var encounter = new Encounter(warror, wawror);
            encounter.Fight();
        }
    }
}
