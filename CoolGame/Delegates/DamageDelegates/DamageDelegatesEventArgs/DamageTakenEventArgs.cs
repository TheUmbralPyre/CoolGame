using System;

namespace CoolGame.Delegates.DamageDelegates.DamageDelegatesEventArgs
{
    public class DamageTakenEventArgs : EventArgs
    {
        public DamageTakenEventArgs(double damageTaken)
        {
            // Set the Taken Damage to the Recieved Parameter
            DamageTaken = damageTaken;
        }

        /// <summary>
        /// Represents the Taken Damage.
        /// </summary>
        public double DamageTaken { get; private set; }
    }
}
