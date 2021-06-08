using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up and assign the players
            HumanPlayer player1 = new HumanPlayer();
            player1.Name = "Bob";

            OneHigherPlayer player2 = new OneHigherPlayer();
            player2.Name = "Sue";

            SmackTalkingPlayer player3 = new SmackTalkingPlayer();
            player3.Name = "Wilma";
            player3.Taunt = "Sucker";
            player3.YellTaunt();

            CreativeSmackTalkingPlayer player4 = new CreativeSmackTalkingPlayer();
            player4.Name = "Your Mom";
            player4.Taunts.Add("You roll like a girl");
            player4.Taunts.Add("ROOKIE");
            player4.Taunts.Add("This is just embarassing");
            player4.Taunts.Add("Your roll stinks as much as you.");

            SoreLoserPlayer player5 = new SoreLoserPlayer();
            player5.Name = "Betty";

            UpperHalfPlayer player6 = new UpperHalfPlayer();
            player6.Name = "Fancy Pants";

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            // Calling the games and assigning opponents for the rounds..

            List<Player> players = new List<Player>() {
                player1, player2, player3, player4, player5, player6, large
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {

            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];

                try
                {
                    player1.Play(player2);
                }
                catch (Exception ex)
                {
                    if (ex.Message == "no fair!! You cheated")
                    {
                        Console.WriteLine("Bratty Betty throws a fit");
                        continue;
                    }
                }
            }



        }
    }
}