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
        /// Writes the Border String to the Console.
        /// </summary>
        public static void WriteEncounterBorderText()
        {
            Console.WriteLine(border);
        }

        /// <summary>
        /// Writes the Opening Text for the Turn.
        /// </summary>
        /// <param name="turnNumber"> The Number of the Turn. </param>
        /// <param name="turnOwnerName"> The Name of the Turn Owner. </param>
        public static void WriteTurnTextOpening(int turnNumber, string turnOwnerName)
        {
            Console.WriteLine();
            Console.Write($"TURN {turnNumber} ");
            ConsoleColoredText.WriteLineName(turnOwnerName);
            Console.WriteLine();
        }

        /// <summary>
        /// Writes the Closing Text for the Turn.
        /// </summary>
        /// <param name="turnNumber"> The Number of the Turn. </param>
        public static void WriteTurnTextClosing(int turnNumber)
        {
            Console.WriteLine();
            Console.WriteLine($"END OF TURN {turnNumber}");
            Console.WriteLine();
        }
    }
}
