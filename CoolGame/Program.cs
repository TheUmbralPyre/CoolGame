using CoolGame.Classes;
using System;

namespace CoolGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var warror = new Berserker("Rolf", 1, 20, 1, 1);
            var wawror = new Reaver("Aureus", 2, 1.5 ,10);

            Combat.Fight(wawror, warror);
        }
    }
}
