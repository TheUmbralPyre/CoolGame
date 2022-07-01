using CoolGame.Classes.CharacterClasses.CharacterStatClasses;
using CoolGame.Delegates.DamageDelegates;

namespace CoolGame.Interfaces.CharacterInterfaces
{
    public interface ICharacter
    {
        /// <summary>
        /// Represents the Name of the Character.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Represents the Attack Value of the Character.
        /// </summary>
        CharacterAttribute Attack { get; }

        /// <summary>
        /// Reoresents the Speed Value of the Character.
        /// </summary>
        CharacterAttribute Speed { get; }

        /// <summary>
        /// Represents the Health Value of the Character.
        /// </summary>
        CharacterAttribute Health { get; }

        /// <summary>
        /// Represents the Defense Value of the Character.
        /// </summary>
        CharacterAttribute Defense { get; }

        /// <summary>
        /// Listens for when a Character Takes Damage.
        /// </summary>
        event DamageTakenDelegate DamageTaken;

        /// <summary>
        /// Listens for when a Character Deals Damage.
        /// </summary>
        event DamageDealtDelegate DamageDealt;

        /// <summary>
        /// Handles Taking Damage.
        /// </summary>
        /// <param name="attacker"> The Attacker from whom Damage will be Taken. </param>
        /// <returns> The Amount of Damage Taken. </returns>
        double TakeDamage(ICharacter attacker);

        /// <summary>
        /// Handles Dealing Damage.
        /// </summary>
        /// <param name="target"> The Target to whom Damage will be Dealt. </param>
        /// <returns> The Amount of Damage Dealt. </returns>
        double DealDamage(ICharacter target);
    }
}
