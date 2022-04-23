using CoolGame.Interfaces.CharacterInterfaces;

namespace CoolGame.Interfaces.AbilityInterfaces.BaseAbilityInterface
{
    public interface IAbilityBase
    {
        /// <summary>
        /// Represents the Name of this Ability.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Represents the User of this Ability.
        /// </summary>
        ICharacter User { get; }
    }
}
