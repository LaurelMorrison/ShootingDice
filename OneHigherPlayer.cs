using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            int higherRoll = Roll();
            int lowerRoll = higherRoll - 1;

            Console.WriteLine($"{Name} rolls a {higherRoll}");
            Console.WriteLine($"{other.Name} rolls a {lowerRoll}");
            if (higherRoll > lowerRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (higherRoll < lowerRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}
