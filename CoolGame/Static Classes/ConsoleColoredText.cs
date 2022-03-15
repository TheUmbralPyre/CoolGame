using System;

namespace CoolGame.Static_Classes
{
    static internal class ConsoleColoredText
    {
        const ConsoleColor nameColor = ConsoleColor.Cyan;
        const ConsoleColor attackColor = ConsoleColor.Red;
        const ConsoleColor healthColor = ConsoleColor.Green;
        const ConsoleColor abilityColor = ConsoleColor.DarkMagenta;

        /// <summary>
        /// Writes to the Console in Color.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        /// <param name="color"> The Color in Which the Text will be in.</param>
        static public void Write(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        /// <summary>
        /// Writes to the Console in a Color that represents a Name.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteName(string text)
        {
            Write(text, nameColor);
        }

        /// <summary>
        /// Writes to the Console in a Color that represents Attack.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteAttack(string text)
        {
            Write(text, attackColor);
        }

        /// <summary>
        /// Writes to the Console in a Color that represents Health.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteHealth(string text)
        {
            Write(text, healthColor);
        }

        /// <summary>
        /// Writes to the Console in a Color that represents an Ability.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteAbility(string text)
        {
            Write(text, abilityColor);
        }
    }
}
