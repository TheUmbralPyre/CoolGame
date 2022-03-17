﻿using CoolGame.Classes;
using CoolGame.Delegates;
using CoolGame.Static_Classes;
using System;

namespace CoolGame
{
    internal abstract class Character : NamedObject, ICharacter
    {
        /// <summary>
        /// Represents the Attack Value of the Character.
        /// </summary>
        private double attack;
        /// <summary>
        /// Exposes the attack field.
        /// </summary>
        public double Attack
        {
            get
            {
                return attack;
            }
            private set
            {
                attack = value;
            }
        }

        /// <summary>
        /// Represents the Health Value of the Character.
        /// </summary>
        private double health;

        /// <summary>
        /// Exposes the health field.
        /// </summary>
        public double Health
        {
            get
            {
                return health;
            }
            protected set
            {
                health = value;
            }
        }

        /// <summary>
        /// Reoresents the Speed Value of the Character.
        /// </summary>
        private double speed;

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
        /// Represents the Damage that the Character will Deal on an Attack.
        /// </summary>
        public abstract double Damage { get; }

        public event DamageTakenDelegate DamageTaken;

        public event DamageDealtDelegate DamageDealt;

        protected Character(string name, double attack, double health, double speed) : base(name)
        {
            Attack = attack;
            Health = health;
            Speed = speed;
        }

        public virtual void TakeDamage(ICharacter attacker)
        {
            ConsoleColoredText.WriteName(attacker.Name);
            Console.Write(" has dealt ");
            ConsoleColoredText.WriteAttack(attacker.Damage.ToString());
            Console.Write(" points of ");
            ConsoleColoredText.WriteAttack("Damage");
            Console.Write(" to ");
            ConsoleColoredText.WriteName(Name);
            Console.WriteLine("!");

            // Subtract the Amount of Damage from Character Health
            Health -= attacker.Damage;

            // If the DamageTaken event is Listening...
            if (DamageTaken != null)
            {
                // ...Raise the event
                DamageTaken(this, new EventArgs());
            }

            ConsoleColoredText.WriteName(Name);
            Console.Write(" has ");
            ConsoleColoredText.WriteHealth(Health.ToString());
            Console.Write(" points of ");
            ConsoleColoredText.WriteHealth("Health");
            Console.WriteLine(" left!");

            ConsoleColoredText.WriteName(attacker.Name);
            Console.Write(" has ");
            ConsoleColoredText.WriteHealth(attacker.Health.ToString());
            Console.Write(" points of ");
            ConsoleColoredText.WriteHealth("Health");
            Console.WriteLine(" left!");
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
    }
}
