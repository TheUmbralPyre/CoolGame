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

        public Reaver(string name, double attack, double health) : base(name, attack, health)
        {
            DamageDealt += RevearHeal;
        }

        private void RevearHeal(object sender, EventArgs args)
        {
            Console.WriteLine($"[Reaver]: {Name} has Gained {RevearHealthGain} Health After Dealing Damage!");

            Health += RevearHealthGain;
        }
    }
}
