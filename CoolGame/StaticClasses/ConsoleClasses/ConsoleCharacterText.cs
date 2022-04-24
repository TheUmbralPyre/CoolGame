using System;

namespace CoolGame.StaticClasses.ConsoleClasses
{
    public class ConsoleCharacterText
    {
        /// <summary>
        /// Writes to the Console After a Character Has Dealt Damage.
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

        public static void DisplayAbilityDialogue(string name, string[] abilityDialogues)
        {
            ConsoleColoredText.WriteName(name);
            Console.Write(": ");
            Console.WriteLine(abilityDialogues[new Random().Next(abilityDialogues.Length)]);
        }
    }
}
