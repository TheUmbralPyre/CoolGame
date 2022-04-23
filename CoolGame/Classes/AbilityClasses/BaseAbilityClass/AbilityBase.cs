using CoolGame.AbstractClasses;
using CoolGame.Interfaces.AbilityInterfaces.BaseAbilityInterface;
using CoolGame.Interfaces.CharacterInterfaces;

namespace CoolGame.Classes.AbilityClasses.BaseAbilityClass
{
    public abstract class AbilityBase : NamedObject, IAbilityBase
    {
        /// <summary>
        /// Writes the Ability's Text to the Console. 
        /// </summary>
        protected abstract void WriteAbilityText();

        /// <summary>
        /// Represents the User of this Ability.
        /// </summary>
        public ICharacter User { get; private set; }

        public AbilityBase(string name, ICharacter user)
            : base(name)
        {
            // Set the User using the Recieved Parameter
            User = user;
        }
    }
}
