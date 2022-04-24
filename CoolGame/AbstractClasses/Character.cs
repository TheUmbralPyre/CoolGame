using System;
using System.Collections.Generic;
using CoolGame.Classes.CharacterClasses.CharacterStatClasses;
using CoolGame.Delegates.DamageDelegates;
using CoolGame.Delegates.DamageDelegates.DamageDelegatesEventArgs;
using CoolGame.Interfaces.AbilityInterfaces.BaseAbilityInterface;
using CoolGame.Interfaces.CharacterInterfaces;
using CoolGame.StaticClasses.ConsoleClasses;

namespace CoolGame.AbstractClasses
{
    public abstract class Character : NamedObject, ICharacter
    {
        protected Character(string name, double attack, double health, double speed, double defense)
            : base(name)
        {
            // Initialize Character Attributes with the Recived Parameters
            Attack = new CharacterAttribute(attack);
            Health = new CharacterAttribute(health);
            Speed = new CharacterAttribute(speed);
            Defense = new CharacterAttribute(defense);
            // Initialize a New List of Abilities
            Abilities = new List<IAbilityBase>();
        }

        /// <summary>
        /// Represents the Attack Stat of the Character.
        /// </summary>
        public CharacterAttribute Attack { get; private set; }

        /// <summary>
        /// Represents the Speed Value of the Character.
        /// </summary>
        public CharacterAttribute Speed { get; private set; }

        /// <summary>
        /// Represents the Health Value of the Character.
        /// </summary>
        public CharacterAttribute Health { get; private set; }

        /// <summary>
        /// Represents the Defense Value of the Character.
        /// </summary>
        public CharacterAttribute Defense { get; private set; }

        /// <summary>
        /// Listens for when a Character Takes Damage.
        /// </summary>
        public event DamageTakenDelegate DamageTaken;

        /// <summary>
        /// Listens for when a Character Deals Damage.
        /// </summary>
        public event DamageDealtDelegate DamageDealt;

        /// <summary>
        /// Handles Taking Damage.
        /// </summary>
        /// <param name="attacker"> The Attacker from whom Damage will be Taken. </param>
        public void TakeDamage(ICharacter attacker)
        {
            // Initialize the Taken Damage as the Attacker's Attack Minus the Defender's Defense
            var damageTaken = attacker.Attack.CurrentValue - Defense.CurrentValue;

            // Subtract the Amount of Damage from Character Health
            Health.DecreaseBy(damageTaken);

            ConsoleCharacterText.DealtDamage(attacker.Name, Name, damageTaken);

            // If the DamageTaken event is Listening...
            if (DamageTaken != null)
            {
                // ...Raise the event
                DamageTaken(this, new DamageTakenEventArgs(damageTaken));
            }
        }

        /// <summary>
        /// Handles Dealing Damage.
        /// </summary>
        /// <param name="target"> The Target to whom Damage will be Dealt. </param>
        public void DealDamage(ICharacter target)
        {
            // Handle the Target Taking Damage
            target.TakeDamage(this);

            // If the DamageDealt event is Listening...
            if (DamageDealt != null)
            {
                // ...Raise the event
                DamageDealt(this, new EventArgs());
            }
        }

        /// <summary>
        /// Displays the Values of the Character's Attributes.
        /// </summary>
        public void DisplayAttributes()
        {
            ConsoleCharacterText.WriteCharacterAttributes(Name, Attack.CurrentValue, Health.CurrentValue,
                Speed.CurrentValue, Defense.CurrentValue);
        }

        /// <summary>
        /// Stores the Character's Abilities.
        /// </summary>
        public List<IAbilityBase> Abilities;
    }
}
