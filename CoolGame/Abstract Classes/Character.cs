using CoolGame.Classes;
using CoolGame.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            protected set
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

        public event DamageTakenDelegate DamageTaken;

        public event DamageDealtDelegate DamageDealt;

        protected Character(string name, double attack, double health) : base(name)
        {
            Attack = attack;
            Health = health;
        }

        public virtual void TakeDamage(double amount)
        {
            Console.WriteLine($"{Name} took {amount} points of DMG!");

            // Subtract the Amount of Damage from Character Health
            Health -= amount;

            // If the DamageTaken event is Listening...
            if (DamageTaken != null)
            {
                // ...Raise the event
                DamageTaken(this, new EventArgs());
            }

            Console.WriteLine($"{Name} has {Health} points Left!");
        }

        public virtual void DealDamage(ICharacter Target)
        {
            // Handle the Target Taking Damage
            Target.TakeDamage(Attack);

            // If the DamageDealt event is Listening...
            if (DamageDealt != null)
            {
                // ...Raise the event
                DamageDealt(this, new EventArgs());
            }
        }
    }
}
