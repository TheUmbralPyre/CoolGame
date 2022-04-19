using CoolGame.Interfaces;
using CoolGame.StaticClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGame.Classes
{
    internal class AbilityBerserker : IAbilityBerserker
    {
        string name = "Berserker";
        public string Name
        {
            get
            {
                return name;
            }
        }

        public ICharacter User { get; private set; }

        public AbilityBerserker(Character user)
        {
            User = user;
            User.DamageTaken += BerserkGainAttack;
        }

        /// <summary>
        /// Reresents the Attack Gain from Berserk.
        /// </summary>
        public double berserkAttackGain { get; private set; }

        /// <summary>
        /// Represents the Current Bonus Attack from Berserker.
        /// </summary>
        public double berserkerBonusAttack { get; set; }

        /// <summary>
        /// Trigger the Berserk Ability. Increasing the Attack of the Berserker after Taking Damage.
        /// </summary>
        /// <param name="sender"> The Event Sender. </param>
        /// <param name="args"> The Event Arguments. </param>
        public void BerserkGainAttack(object sender, EventArgs args)
        {
            ConsoleCharacterText.BerserkerAttackGain(Name, User.Name, berserkAttackGain);

            // Increase the Berserkers Attack by The Berserker Attack Gain
            berserkerBonusAttack += berserkAttackGain;
        }
    }
}
