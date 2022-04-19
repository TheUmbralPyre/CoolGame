using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGame.Interfaces
{
    public interface IAbilityBase
    {
        string Name { get; }

        ICharacter User { get; }
    }
}
