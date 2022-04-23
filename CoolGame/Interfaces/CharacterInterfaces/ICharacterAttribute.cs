namespace CoolGame.Interfaces.CharacterInterfaces
{
    public interface ICharacterAttribute
    {
        /// <summary>
        /// Represents the Base Value of this Attribute. 
        /// </summary>
        double BaseValue { get; }

        /// <summary>
        /// Represents the CurrentValue of this Attribute.
        /// </summary>
        /// <remarks>
        /// Includes Increases and Decreases.
        /// </remarks>
        double CurrentValue { get; }
    }
}
