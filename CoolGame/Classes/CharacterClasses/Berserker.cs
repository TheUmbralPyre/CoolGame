using CoolGame.AbstractClasses;
using CoolGame.Classes.AbilityClasses;

namespace CoolGame.Classes.CharacterClasses
{
    internal class Berserker : Character
    {
        public Berserker(string name, double attack, double health, double speed, double defense)
            : base(name, attack, health, speed, defense)
        {
            Abilities.Add(new AbilityBerserker(this));
        }
    }
}
