using CoolGame.Static_Classes;
using System;

namespace CoolGame.Classes
{
    internal class Berserker : Character
    {
        /// <summary>
        /// Reresents the Attack Gained from Berserk.
        /// </summary>
        private double BerserkAttackGain { get; set; }

        public Berserker(string name, double attack, double health, double berserkAttackGain)
            : base(name, attack, health)
        {
            BerserkAttackGain = berserkAttackGain;
            DamageTaken += BerserkGainAttack;
        }

        /// <summary>
        /// Trigger the Berserk Ability. Increasing the Attack of the Berserker after Taking Damage.
        /// </summary>
        /// <param name="sender"> The Event Sender. </param>
        /// <param name="args"> The Event Arguments. </param>
        private void BerserkGainAttack(object sender, EventArgs args)
        {
            ConsoleColoredText.WriteAbility("[Berserker]");
            Console.Write(": ");
            ConsoleColoredText.WriteName(Name);
            Console.Write(" Has Gained ");
            ConsoleColoredText.WriteAttack($"{BerserkAttackGain} Attack");
            Console.WriteLine("!");

            // Increase the Berserkers Attack by The Berserker Attack Gain
            Attack += BerserkAttackGain;
        }
    }
}
