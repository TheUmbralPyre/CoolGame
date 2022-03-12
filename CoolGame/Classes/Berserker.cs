using CoolGame.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGame.Classes
{
    internal class Berserker : Character
    {
        private double BerserkAttackGain { get; set; }

        public override event DamageTakenDelegate DamageTaken;

        public override event DamageDealtDelegate DamageDealt;

        public Berserker(string name, double attack, double health, double berserkAttackGain) : base(name, attack, health)
        {
            BerserkAttackGain = berserkAttackGain;
            DamageTaken += BerserkGainAttack;
        }

        public override void TakeDamage(double amount)
        {
            Console.WriteLine($"{Name} took {amount} points of DMG!");

            Health -= amount;

            if (DamageTaken != null)
            {
                DamageTaken(this, new EventArgs());
            }

            Console.WriteLine($"{Name} has {Health} points Left!");
        }

        public override void DealDamage(ICharacter Target)
        {
            Target.TakeDamage(Attack);
        }

        private void BerserkGainAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"[Berserker]: {Name} has Gained {BerserkAttackGain} Attack!");

            Attack += BerserkAttackGain;
        }
    }
}
