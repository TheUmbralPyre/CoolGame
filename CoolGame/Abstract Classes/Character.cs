using CoolGame.Classes;
using CoolGame.Delegates;
using CoolGame.Interfaces;
using CoolGame.StaticClasses;
using System;
using System.Collections.Generic;

namespace CoolGame
{
    public abstract class Character : NamedObject, ICharacter
    {
        /// <summary>
        /// Represents the Attack Value of the Character.
        /// </summary>
        public double attack;

        /// <summary>
        /// Represents the Speed Value of the Character.
        /// </summary>
        private double speed;

        /// <summary>
        /// Represents the Health Value of the Character.
        /// </summary>
        private double health;

        /// <summary>
        /// Represents the Health Value of the Character.
        /// </summary>
        private double defense;

        protected Character(string name, double attack, double health, double speed, double defense)
            : base(name)
        {
            Attack = attack;
            Health = health;
            Speed = speed;
            Defense = defense;
            Abilities = new List<IAbilityBase>();
        }

        /// <summary>
        /// Exposes the attack field.
        /// </summary>
        public double Attack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }

        /// <summary>
        /// Exposes the speed field. 
        /// </summary>
        public double Speed
        {
            get
            {
                return speed;
            }
            private set
            {
                speed = value;
            }
        }

        /// <summary>
        /// Exposes the health field.
        /// </summary>
        public double Health
        {
            get
            {
                return health;
            }
            private set
            {
                health = value;
            }
        }

        /// <summary>
        /// Exposes the defense field.
        /// </summary>
        public double Defense
        {
            get
            {
                return defense;
            }
            private set
            {
                defense = value;
            }
        }

        /// <summary>
        /// Represents the Damage that the Character will Deal on an Attack.
        /// </summary>
        public virtual double Damage
        {
            get
            {
                return Attack;
            }
        }

        public event DamageTakenDelegate DamageTaken;

        public event DamageDealtDelegate DamageDealt;

        public virtual void TakeDamage(ICharacter attacker)
        {
            var damageTaken = attacker.Damage - Defense;

            // Subtract the Amount of Damage from Character Health
            Health -= damageTaken;

            ConsoleCharacterText.DealtDamage(attacker.Name, Name, damageTaken);

            // If the DamageTaken event is Listening...
            if (DamageTaken != null)
            {
                // ...Raise the event
                DamageTaken(this, new EventArgs());
            }
        }

        public virtual void DealDamage(ICharacter target)
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

        public virtual void Heal(double amountToRestore)
        {
            Health += amountToRestore;

            //// If the Healed event is Listening...
            //if (Healed != null)
            //{
            //    // ...Raise the event
            //    Healed(this, new EventArgs());
            //}
        }

        public List<IAbilityBase> Abilities;
    }
}
