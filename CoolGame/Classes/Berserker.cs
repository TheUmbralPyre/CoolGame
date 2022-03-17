using CoolGame.Static_Classes;
using System;

namespace CoolGame.Classes
{
    internal class Berserker : Character
    {
        /// <summary>
        /// Reresents the Attack Gain from Berserk.
        /// </summary>
        private double berserkAttackGain;

        /// <summary>
        /// Represents the Current Bonus Attack from Berserker.
        /// </summary>
        private double berserkerBonusAttack = 0;

        /// <summary>
        /// Represents the Damage that the Character will Deal on an Attack.
        /// </summary>
        public override double Damage
        {
            get
            {
                return Attack + berserkerBonusAttack;
            }
        }

        public Berserker(string name, double attack, double health, double speed, double berserkAttackGain)
            : base(name, attack, health, speed)
        {
            this.berserkAttackGain = berserkAttackGain;
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
            ConsoleColoredText.WriteAttack($"{berserkAttackGain} Attack");
            Console.WriteLine("!");

            // Increase the Berserkers Attack by The Berserker Attack Gain
            berserkerBonusAttack += berserkAttackGain;
        }
    }
}
