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
        private double attack;
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

        private double health;
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

            Health -= amount;

            if (DamageTaken != null)
            {
                DamageTaken(this, new EventArgs());
            }

            Console.WriteLine($"{Name} has {Health} points Left!");
        }

        public virtual void DealDamage(ICharacter Target)
        {
            Target.TakeDamage(Attack);

            if (DamageDealt != null)
            {
                DamageDealt(this, new EventArgs());
            }
        }
    }
}
