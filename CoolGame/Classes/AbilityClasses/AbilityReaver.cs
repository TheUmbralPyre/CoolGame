using System;
using CoolGame.AbstractClasses;
using CoolGame.StaticClasses.ConsoleClasses;
using CoolGame.Classes.AbilityClasses.BaseAbilityClass;

namespace CoolGame.Classes.AbilityClasses
{
    public class AbilityReaver : AbilityBase
    {
        /// <summary>
        /// Represents the Ability's Name.
        /// </summary>
        private const string name = "Reaver";

        /// <summary>
        /// Writes the Ability's Text to the Console. 
        /// </summary>
        protected override void WriteAbilityText()
        {
            ConsoleColoredText.WriteAbility($"[{Name}]");
            Console.Write(": ");
            ConsoleColoredText.WriteName(User.Name);
            Console.Write(" has gained ");
            ConsoleColoredText.WriteHealth($"{ReaverHealthGain}");
            Console.Write(" points of ");
            ConsoleColoredText.WriteHealth("Health");
            Console.WriteLine("!");
        }

        public AbilityReaver(Character user)
            : base(name, user)
        {
            // Assign a Method to an User's Event
            User.DamageDealt += ReaverHeal;
        }

        /// <summary>
        /// Represents the Health Gain from Reaver.
        /// </summary>
        public double ReaverHealthGain
        {
            get
            {
                return User.Attack.CurrentValue / 2;
            }
        }

        /// <summary>
        /// Heals the Reaver after Dealing Damage.
        /// </summary>
        /// <param name="sender"> The Event Sender. </param>
        /// <param name="args"> The Event Arguments. </param>
        public void ReaverHeal(object sender, EventArgs args)
        {
            // Increase the Reavers Health by the Reaver Health Gain
            User.Health.IncreaseBy(ReaverHealthGain);

            // Write the Abilitiy's text to the Console
            WriteAbilityText();
        }
    }
}
