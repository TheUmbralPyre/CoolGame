using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGame.Interfaces
{
    public interface IAbilityReaver : IAbilityBase
    {
        double ReaverHealthGain { get; }

        void ReaverHeal(object sender, EventArgs args);
    }
}
