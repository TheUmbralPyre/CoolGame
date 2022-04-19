using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGame.Interfaces
{
    interface IAbilityBerserker : IAbilityBase
    {
        /// <summary>
        /// Reresents the Attack Gain from Berserk.
        /// </summary>
        double berserkAttackGain { get; }

        /// <summary>
        /// Represents the Current Bonus Attack from Berserker.
        /// </summary>
        double berserkerBonusAttack { get; }

        /// <summary>
        /// Trigger the Berserk Ability. Increasing the Attack of the Berserker after Taking Damage.
        /// </summary>
        /// <param name="sender"> The Event Sender. </param>
        /// <param name="args"> The Event Arguments. </param>
        void BerserkGainAttack(object sender, EventArgs args);
    }
}
