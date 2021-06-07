using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {
            Console.Write("You're up! What number do you want to pick (1-6)");
            int selectedRoll = Int32.Parse(Console.ReadLine());
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {selectedRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (selectedRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (selectedRoll < otherRoll)
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