using System;
using CoolGame.AbstractClasses;
using CoolGame.Interfaces.AbilityInterfaces;
using CoolGame.Interfaces.CharacterInterfaces;
using CoolGame.StaticClasses.ConsoleClasses;

namespace CoolGame.Classes.AbilityClasses
{
    internal class AbilityBerserker : IAbilityBerserker
    {
        string name = "Berserker";

        private void WriteBerserkerAttackGainText()
        {
            ConsoleColoredText.WriteAbility($"[{Name}]");
            Console.Write(": ");
            ConsoleColoredText.WriteName(User.Name);
            Console.Write(" Has Gained ");
            ConsoleColoredText.WriteAttack($"{berserkAttackGain} Attack");
            Console.WriteLine("!");
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public ICharacter User { get; private set; }

        public AbilityBerserker(Character user)
        {
            User = user;
            User.DamageTaken += BerserkGainAttack;
        }

        /// <summary>
        /// Reresents the Attack Gain from Berserk.
        /// </summary>
        public double berserkAttackGain { get; private set; }

        /// <summary>
        /// Represents the Current Bonus Attack from Berserker.
        /// </summary>
        public double berserkerBonusAttack { get; set; }

        /// <summary>
        /// Trigger the Berserk Ability. Increasing the Attack of the Berserker after Taking Damage.
        /// </summary>
        /// <param name="sender"> The Event Sender. </param>
        /// <param name="args"> The Event Arguments. </param>
        public void BerserkGainAttack(object sender, EventArgs args)
        {
            WriteBerserkerAttackGainText();

            // Increase the Berserkers Attack by The Berserker Attack Gain
            berserkerBonusAttack += berserkAttackGain;
        }
    }
}
