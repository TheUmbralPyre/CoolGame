using CoolGame.Delegates;

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
        double Attack { get; }

        /// <summary>
        /// Reoresents the Speed Value of the Character.
        /// </summary>
        double Speed { get; }

        /// <summary>
        /// Represents the Health Value of the Character.
        /// </summary>
        double Health { get; }

        /// <summary>
        /// Represents the Defense Value of the Character.
        /// </summary>
        double Defense { get; }

        /// <summary>
        /// Represents the Damage that the Character will Deal on an Attack.
        /// </summary>
        abstract double Damage { get; }

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
        void TakeDamage(ICharacter attacker);

        /// <summary>
        /// Handles Dealing Damage.
        /// </summary>
        /// <param name="target"> The Target to whom Damage will be Dealt. </param>
        void DealDamage(ICharacter target);

        void Heal(double amountToRestore);
    }
}
