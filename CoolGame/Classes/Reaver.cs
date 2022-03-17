﻿using CoolGame.Static_Classes;
using System;

namespace CoolGame.Classes
{
    internal class Reaver : Character
    {
        /// <summary>
        /// Represents the Health Gain from Reaver.
        /// </summary>
        private double ReaverHealthGain
        {
            get
            {
                return Attack / 2; 
            }
        }

        /// <summary>
        /// Represents the Damage that the Character will Deal on an Attack.
        /// </summary>
        public override double Damage
        {
            get
            {
                return Attack;
            }
        }

        public Reaver(string name, double attack, double health, double speed)
            : base(name, attack, health, speed)
        {
            DamageDealt += RevearHeal;
        }

        /// <summary>
        /// Trigger the Reaver Ability. Healing the Reaver after Dealing Damage.
        /// </summary>
        /// <param name="sender"> The Event Sender. </param>
        /// <param name="args"> The Event Arguments. </param>
        private void RevearHeal(object sender, EventArgs args)
        {
            ConsoleColoredText.WriteAbility("[Reaver]");
            Console.Write(": ");
            ConsoleColoredText.WriteName(Name);
            Console.Write(" has gained ");
            ConsoleColoredText.WriteHealth($"{ReaverHealthGain}");
            Console.Write(" points of ");
            ConsoleColoredText.WriteHealth("Health");
            Console.WriteLine("!");

            // Increase the Reavers Health by the Reaver Health Gain
            Health += ReaverHealthGain;
        }
    }
}
