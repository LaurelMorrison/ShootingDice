using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {

        public override int Roll()
        {
            return new Random().Next(4, 6);
        }
        public override void Play(Player other)
        {
            int soreLoserUpperRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {soreLoserUpperRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (soreLoserUpperRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (soreLoserUpperRoll < otherRoll)
            {
                throw new Exception("I'm from the upper half, I should've won");
            }
            else
            {
                Console.WriteLine("It's a tie");
            }
        }
    }
}