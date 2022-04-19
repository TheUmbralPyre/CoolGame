using CoolGame.Interfaces.CharacterInterfaces;

namespace CoolGame.Interfaces.AbilityInterfaces.BaseAbilityInterface
{
    public interface IAbilityBase
    {
        string Name { get; }

        ICharacter User { get; }
    }
}
