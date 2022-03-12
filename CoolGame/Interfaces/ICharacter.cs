using CoolGame.Delegates;

namespace CoolGame
{
    internal interface ICharacter
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
        /// Represents the Health Value of the Character.
        /// </summary>
        double Health { get; }

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
        /// <param name="amount"> The Amount of Damage to be Taken. </param>
        void TakeDamage(double amount);

        /// <summary>
        /// Handles Dealing Damage.
        /// </summary>
        /// <param name="Target"> The Target to whom Damage will be Dealt. </param>
        void DealDamage(ICharacter Target);
    }
}