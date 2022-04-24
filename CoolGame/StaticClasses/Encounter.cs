using System;
using System.Collections.Generic;
using System.Linq;
using CoolGame.Interfaces.CharacterInterfaces;
using CoolGame.StaticClasses.ConsoleClasses;

namespace CoolGame
{
    public class Encounter
    {
        /// <summary>
        /// The Number of the Current Turn.
        /// </summary>
        private int turnNumber = 1;

        private ICharacter characterOne;
        private ICharacter characterTwo;

        /// <summary>
        /// Switches the Places of the Characters.
        /// </summary>
        private void SwitchCharachters()
        {
            // Initialize a Variable to Temporarily Store the Reference to Character One
            var tempChar = characterOne;
            // Assign the Character Two's Reference to Character One
            characterOne = characterTwo;
            // Assign the Temporary Character's Reference to Character Two 
            characterTwo = tempChar;
        }

        /// <summary>
        /// Incraments the Turn Number.
        /// </summary>
        private void AdvanceTurn()
        {
            // Incrament the Turn Number
            turnNumber += 1;
        }

        public Encounter(ICharacter characterOne, ICharacter characterTwo)
        {
            // Initialize a List with the Recieved Characters
            var speedList = new List<ICharacter>() { characterOne, characterTwo };

            // Sort the Lsit By the Character's Speed
            speedList = speedList.OrderByDescending(x => x.Speed.CurrentValue).ToList();

            // Assign the Faster Character to Character One
            this.characterOne = speedList[0];
            // Assign the Slower Character to Characer Two
            this.characterTwo = speedList[1];
        }

        /// <summary>
        /// Handle a Fight between two Characters.
        /// </summary>
        public void Fight()
        {
            // Display the Values of the Attributes of Both Characters
            characterOne.DisplayAttributes();
            characterTwo.DisplayAttributes();

            // While Both Characters' Health is Above Zero...
            while (characterOne.Health.CurrentValue > 0.0 && characterTwo.Health.CurrentValue > 0.0)
            {
                // ...Handle the First Character Dealing Damage to the Second One
                Attack(characterOne, characterTwo);

                // ...Incrament the Turn Number
                AdvanceTurn();

                // ...Switch the Characters' Places
                SwitchCharachters();
            }
        }

        /// <summary>
        /// The Attacker Deals Damage to the Target and their Stats are Displayed.
        /// </summary>
        /// <param name="attacker"> The Attacking Character. </param>
        /// <param name="target"> The Target of the Attack. </param>
        private void Attack(ICharacter attacker, ICharacter target)
        {
            // Write the Encounter Border Text
            ConsoleEncounterText.WriteEncounterBorderText();

            // Write the Turn Opening Text
            ConsoleEncounterText.WriteTurnTextOpening(turnNumber, attacker.Name);

            // Make the Atttacker Deal Damage to the Target
            attacker.DealDamage(target);

            // Write the Turn Closing Text
            ConsoleEncounterText.WriteTurnTextClosing(turnNumber);

            // Display the Values of the Attributes of Both Characters
            attacker.DisplayAttributes();
            target.DisplayAttributes();

            // Write the Encounter Border Text
            ConsoleEncounterText.WriteEncounterBorderText();
        }
    }
}
