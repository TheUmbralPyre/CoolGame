using System;
using CoolGame.Delegates.AttributeDelegates;
using CoolGame.Interfaces.CharacterInterfaces;

namespace CoolGame.Classes.CharacterClasses.CharacterStatClasses
{
    public class CharacterAttribute : ICharacterAttribute
    {
        public CharacterAttribute(double baseValue)
        {
            // Set the Base Value to the Recieved Parameter
            BaseValue = baseValue;
            // Set the Current Value to the Base Value
            CurrentValue = BaseValue;
        }

        /// <summary>
        /// Represents the Base Value of this Attribute. 
        /// </summary>
        public double BaseValue { get; private set; }

        /// <summary>
        /// Represents the CurrentValue of this Attribute.
        /// </summary>
        /// <remarks>
        /// Includes Increases and Decreases.
        /// </remarks>
        public double CurrentValue { get; private set; }

        /// <summary>
        /// Listents for when this Attribute is Increased.
        /// </summary>
        public event StatIncreaseDelegate StatIncreased;

        /// <summary>
        /// Listents for when this Attribute is Decreased.
        /// </summary>
        public event StatDecreaseDelegate StatDecreased;

        /// <summary>
        /// Increases the Current Value of the Attribute, Raising the StatIncreased Event.
        /// </summary>
        /// <param name="bonusValue"> The Value to be Added </param>
        public void IncreaseBy(double bonusValue)
        {
            // Increase the Current Value by the Bonus Value
            CurrentValue += bonusValue;

            // If the StatIncreased is listening...
            if (StatIncreased != null)
            {
                // ...Raise the Event
                StatIncreased(this, new EventArgs());
            }
        }

        /// <summary>
        /// Decreases the Current Value of the Attribute, Raising the StatDecreased Event.
        /// </summary>
        /// <param name="reductionValue"> The Value to be Subtracted </param>
        public void DecreaseBy(double reductionValue)
        {
            // Reduce the Current Value by the Reduction Value
            CurrentValue -= reductionValue;

            // If the StatDecreased is listening...
            if (StatDecreased != null)
            {
                // ...Raise the Event
                StatDecreased(this, new EventArgs());
            }
        }

    }
}
