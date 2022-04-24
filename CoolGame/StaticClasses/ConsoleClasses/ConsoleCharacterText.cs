using System;

namespace CoolGame.StaticClasses.ConsoleClasses
{
    public static class ConsoleCharacterText
    {
        /// <summary>
        /// Writes the Damage Taken by a Target and the Attacker's Name to the Console.
        /// </summary>
        /// <param name="attackerName"> The Name of the Attacker. </param>
        /// <param name="targetName"> The Name of the Target. </param>
        /// <param name="damageDealt"> The Amount of Damage Dealt. </param>
        public static void DealtDamage(string attackerName,string targetName , double damageDealt)
        {
            ConsoleColoredText.WriteName(attackerName);
            Console.Write(" has ");
            ConsoleColoredText.WriteAttack($"dealt {damageDealt}");
            Console.Write(" points of ");
            ConsoleColoredText.WriteAttack("Damage");
            Console.Write(" to ");
            ConsoleColoredText.WriteName(targetName);
            Console.WriteLine("!");
        }

        /// <summary>
        /// Writes the Values of a Character's Attributes to the Console.
        /// </summary>
        /// <param name="name"> The Name of the Character. </param>
        /// <param name="attack"> The Attack of the Character. </param>
        /// <param name="health"> The Health of the Character. </param>
        /// <param name="speed"> The Speed of the Character. </param>
        /// <param name="defense">The Defense of the Character. </param>
        public static void WriteCharacterAttributes(string name, double attack, double health, double speed, double defense)
        {
            Console.WriteLine("******************");
            ConsoleColoredText.WriteName(name);
            Console.WriteLine("'s Attributes:");
            ConsoleColoredText.WriteLineHealth($"{health} Health");
            ConsoleColoredText.WriteLineAttack($"{attack} Attack");
            ConsoleColoredText.WriteLineDefense($"{defense} Defense");
            ConsoleColoredText.WriteLineSpeed($"{speed} Speed");
            Console.WriteLine("******************");
            Console.WriteLine();
        }

        public static void WriteAbilityDialogue(string name, string[] abilityDialogues)
        {
            ConsoleColoredText.WriteName(name);
            Console.Write(": ");
            Console.WriteLine(abilityDialogues[new Random().Next(abilityDialogues.Length)]);
        }
    }
}
