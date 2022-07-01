using CoolGame.Interfaces.CharacterInterfaces;
using System;

namespace CoolGame.StaticClasses.ConsoleClasses
{
    public static class ConsoleEncounterText
    {
        /// <summary>
        /// A String used to Border The Other Encounter Texts.
        /// </summary>
        const string border = "/////////////////////////////////";

        /// <summary>
        /// Writes the Opening Text for the Turn.
        /// </summary>
        /// <param name="turnNumber"> The Number of the Turn. </param>
        /// <param name="turnOwnerName"> The Name of the Turn Owner. </param>
        public static void WriteTurnTextOpening(int turnNumber, string turnOwnerName)
        {
            Console.WriteLine();
            Console.WriteLine(border + "TURN {0, " + 3 + " } " + border, turnNumber);
            Console.WriteLine();
        }

        /// <summary>
        /// Writes the Closing Text for the Turn.
        /// </summary>
        /// <param name="turnNumber"> The Number of the Turn. </param>
        public static void WriteTurnTextClosing(int turnNumber)
        {
            Console.WriteLine();
            Console.WriteLine(border + "TURN {0, " + 3 + " } " + border, turnNumber);
            Console.WriteLine();
        }

        public static void DisplayCharacterAttributes(ICharacter characterOne, ICharacter characterTwo)
        {
            Console.WriteLine("------------------------------------");

            ConsoleColoredText.WriteName(" Name", -10);
            ConsoleColoredText.WriteName(characterOne.Name, 9);
            ConsoleColoredText.WriteName(characterTwo.Name, 9);
            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            ConsoleColoredText.WriteHealth(" Health", -10);
            ConsoleColoredText.WriteHealth(characterOne.Health.CurrentValue.ToString(), 9);
            ConsoleColoredText.WriteHealth(characterTwo.Health.CurrentValue.ToString(), 9);
            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            ConsoleColoredText.WriteAttack(" Attack", -10);
            ConsoleColoredText.WriteAttack(characterOne.Attack.CurrentValue.ToString(), 9);
            ConsoleColoredText.WriteAttack(characterTwo.Attack.CurrentValue.ToString(), 9);
            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            ConsoleColoredText.WriteDefense(" Defense", -10);
            ConsoleColoredText.WriteDefense(characterOne.Defense.CurrentValue.ToString(), 9);
            ConsoleColoredText.WriteDefense(characterTwo.Defense.CurrentValue.ToString(), 9);
            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            ConsoleColoredText.WriteSpeed(" Speed", -10);
            ConsoleColoredText.WriteSpeed(characterOne.Speed.CurrentValue.ToString(), 9);
            ConsoleColoredText.WriteSpeed(characterTwo.Speed.CurrentValue.ToString(), 9);
            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            Console.WriteLine();
        }
    }
}
