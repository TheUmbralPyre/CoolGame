using System;
using CoolGame.Interfaces.AbilityInterfaces.BaseAbilityInterface;

namespace CoolGame.Interfaces.AbilityInterfaces
{
    public interface IAbilityReaver : IAbilityBase
    {
        double ReaverHealthGain { get; }

        void ReaverHeal(object sender, EventArgs args);
    }
}
