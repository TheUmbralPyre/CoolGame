using System;
using CoolGame.AbstractClasses;
using CoolGame.Interfaces.CharacterInterfaces;
using CoolGame.Interfaces.AbilityInterfaces;
using CoolGame.StaticClasses.ConsoleClasses;

namespace CoolGame.Classes.AbilityClasses
{
    public class AbilityReaver : IAbilityReaver
    {
        string name = "Reaver";

        private void WriteReaverHealText()
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

        public string Name
        {
            get
            {
                return name;
            }
        }

        public ICharacter User { get; private set; }

        public AbilityReaver(Character user)
        {
            User = user;
            User.DamageDealt += ReaverHeal;
        }

        /// <summary>
        /// Represents the Health Gain from Reaver.
        /// </summary>
        public double ReaverHealthGain
        {
            get
            {
                return User.Attack / 2;
            }
        }

        /// <summary>
        /// Trigger the Reaver Ability. Healing the Reaver after Dealing Damage.
        /// </summary>
        /// <param name="sender"> The Event Sender. </param>
        /// <param name="args"> The Event Arguments. </param>
        public void ReaverHeal(object sender, EventArgs args)
        {
            WriteReaverHealText();

            // Increase the Reavers Health by the Reaver Health Gain
            //Heal(ReaverHealthGain);
        }
    }
}
