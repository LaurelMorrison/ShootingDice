using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }

        public virtual void YellTaunt()
        {
            Console.WriteLine($"Roll the dice you, {Taunt}");
        }
    }
}