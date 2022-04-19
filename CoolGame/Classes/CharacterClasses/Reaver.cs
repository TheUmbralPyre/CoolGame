using CoolGame.AbstractClasses;
using CoolGame.Classes.AbilityClasses;

namespace CoolGame.Classes.CharacterClasses
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
