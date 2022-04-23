using System;
using CoolGame.AbstractClasses;
using CoolGame.Classes.AbilityClasses.BaseAbilityClass;
using CoolGame.Delegates.DamageDelegates.DamageDelegatesEventArgs;
using CoolGame.StaticClasses.ConsoleClasses;

namespace CoolGame.Classes.AbilityClasses
{
    internal class AbilityBerserker : AbilityBase
    {
        /// <summary>
        /// Represents the Ability's Name.
        /// </summary>
        private const string name = "Berserker";

        /// <summary>
        /// Writes the Ability's Text to the Console. 
        /// </summary>
        protected override void WriteAbilityText()
        {
            ConsoleColoredText.WriteAbility($"[{Name}]");
            Console.Write(": ");
            ConsoleColoredText.WriteName(User.Name);
            Console.Write(" Has Gained ");
            ConsoleColoredText.WriteAttack($"{berserkAttackGain} Attack");
            Console.WriteLine("!");
        }

        public AbilityBerserker(Character user)
            : base(name, user)
        {
            // Assign a Method to an User's Event
            User.DamageTaken += BerserkGainAttack;
        }

        /// <summary>
        /// Reresents the Attack Gain from Berserk.
        /// </summary>
        public double berserkAttackGain { get; private set; }

        /// <summary>
        /// Increases the Attack of the Berserker After Taking Damage.
        /// </summary>
        /// <param name="sender"> The Event Sender. </param>
        /// <param name="args"> The Event Arguments. </param>
        public void BerserkGainAttack(object sender, DamageTakenEventArgs args)
        {
            // Set the Attack Gain to The Amount of Damage Taken
            berserkAttackGain = args.DamageTaken;
            
            // Increase the User's Attack by The Attack Gain
            User.Attack.IncreaseBy(berserkAttackGain);
            
            // Write the Abilitiy's text to the Console
            WriteAbilityText();
        }
    }
}
