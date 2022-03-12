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

        public abstract event DamageTakenDelegate DamageTaken;

        public abstract event DamageDealtDelegate DamageDealt;

        protected Character(string name, double attack, double health) : base(name)
        {
            Attack = attack;
            Health = health;
        }
        // Make these calsses Virtual
        public abstract void TakeDamage(double amount);

        public abstract void DealDamage(ICharacter Target);
    }
}
