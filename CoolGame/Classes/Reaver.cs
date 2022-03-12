using CoolGame.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGame.Classes
{
    internal class Reaver : Character
    {
        private double RevearHealthGain
        {
            get
            {
                return Attack / 2; 
            }
        }

        public override event DamageTakenDelegate DamageTaken;

        public override event DamageDealtDelegate DamageDealt;

        public Reaver(string name, double attack, double health) : base(name, attack, health)
        {
            DamageDealt += RevearHeal;
        }

        public override void TakeDamage(double amount)
        {
            Console.WriteLine($"{Name} took {amount} points of DMG!");

            Health -= amount;

            Console.WriteLine($"{Name} has {Health} points Left!");

        }

        private void RevearHeal(object sender, EventArgs args)
        {
            Console.WriteLine($"[Reaver]: {Name} has Gained {RevearHealthGain} Health After Dealing Damage!");

            Health += RevearHealthGain;
        }

        public override void DealDamage(ICharacter Target)
        {
            Target.TakeDamage(Attack);

            if (DamageDealt != null)
            {
                DamageDealt(this, new EventArgs());
            }
        }
    }
}
