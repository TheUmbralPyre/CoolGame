using CoolGame.Interfaces;
using CoolGame.StaticClasses;
using System;
using System.Collections.Generic;

namespace CoolGame.Classes
{
    internal class Reaver : Character
    {
        public Reaver(string name, double attack, double health, double speed, double defense)
            : base(name, attack, health, speed, defense)
        {
            Abilities.Add(new AbilityReaver(this));
        }
    }
}
