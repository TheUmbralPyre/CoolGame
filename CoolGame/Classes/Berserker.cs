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

        public Berserker(string name, double attack, double health, double berserkAttackGain) : base(name, attack, health)
        {
            BerserkAttackGain = berserkAttackGain;
            DamageTaken += BerserkGainAttack;
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
