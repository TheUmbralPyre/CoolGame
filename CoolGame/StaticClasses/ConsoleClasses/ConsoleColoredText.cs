using System;

namespace CoolGame.StaticClasses.ConsoleClasses
{
    public static class ConsoleColoredText
    {
        const ConsoleColor nameColor = ConsoleColor.Blue;
        const ConsoleColor attackColor = ConsoleColor.Red;
        const ConsoleColor healthColor = ConsoleColor.Green;
        const ConsoleColor speedColor = ConsoleColor.DarkYellow;
        const ConsoleColor defenseColor = ConsoleColor.Cyan;
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
        /// Writes a Line to the Console in Color.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        /// <param name="color"> The Color in Which the Text will be in.</param>
        static public void WriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
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
        /// Writes a Line to the Console in a Color that represents a Name.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteLineName(string text)
        {
            WriteLine(text, nameColor);
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
        /// Writes a Line to the Console in a Color that represents Attack.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteLineAttack(string text)
        {
            WriteLine(text, attackColor);
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
        /// Writes a Line to the Console in a Color that represents Health.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteLineHealth(string text)
        {
            WriteLine(text, healthColor);
        }

        /// <summary>
        /// Writes to the Console in a Color that represents Speed.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteSpeed(string text)
        {
            Write(text, speedColor);
        }

        /// <summary>
        /// Writes a Line to the Console in a Color that represents Speed.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteLineSpeed(string text)
        {
            WriteLine(text, speedColor);
        }

        /// <summary>
        /// Writes to the Console in a Color that represents Defenese.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteDefense(string text)
        {
            Write(text, defenseColor);
        }

        /// <summary>
        /// Writes a Line to the Console in a Color that represents Defenese.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteLineDefense(string text)
        {
            WriteLine(text, defenseColor);
        }

        /// <summary>
        /// Writes to the Console in a Color that represents an Ability.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteAbility(string text)
        {
            Write(text, abilityColor);
        }

        /// <summary>
        /// Writes a Line to the Console in a Color that represents an Ability.
        /// </summary>
        /// <param name="text"> The Text to be Written. </param>
        static public void WriteLineAbility(string text)
        {
            WriteLine(text, abilityColor);
        }
    }
}
