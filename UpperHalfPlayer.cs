using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            return new Random().Next(4, 6);
        }

        public override void Play(Player other)
        {
            int UpperRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {UpperRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (UpperRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (UpperRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                Console.WriteLine("It's a tie");
            }
        }
    }
}