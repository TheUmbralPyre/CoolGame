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
        /// <summary>
        /// Represents the Health Gain from Reaver.
        /// </summary>
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

        /// <summary>
        /// Trigger the Reaver Ability. Healing the Reaver after Dealing Damage.
        /// </summary>
        /// <param name="sender"> The Event Sender. </param>
        /// <param name="args"> The Event Arguments. </param>
        private void RevearHeal(object sender, EventArgs args)
        {
            Console.WriteLine($"[Reaver]: {Name} has Gained {RevearHealthGain} Health After Dealing Damage!");

            // Increase the Reavers Health by the Reaver Health Gain
            Health += RevearHealthGain;
        }
    }
}
