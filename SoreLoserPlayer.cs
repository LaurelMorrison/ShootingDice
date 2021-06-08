using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            int soreLoserRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {soreLoserRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (soreLoserRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (soreLoserRoll < otherRoll)
            {
                throw new Exception("no fair!! You cheated");
            }
            else
            {
                Console.WriteLine("It's a tie");
            }
        }
    }
}