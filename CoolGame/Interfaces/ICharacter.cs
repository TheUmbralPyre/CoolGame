using CoolGame.Delegates;

namespace CoolGame
{
    internal interface ICharacter
    {
        string Name { get; }
        double Attack { get; }
        double Health { get; }

        event DamageTakenDelegate DamageTaken;

        event DamageDealtDelegate DamageDealt;

        void TakeDamage(double amount);

        void DealDamage(ICharacter Target);
    }
}