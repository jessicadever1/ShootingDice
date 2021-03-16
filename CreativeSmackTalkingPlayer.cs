using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }
        public List<string> Taunts { get; set; }
        public override void Play(Player other)
        {
            base.Play(other);
            int RandomIndex = new Random().Next(Taunts.Count);
            string RandomTaunt = Taunts[RandomIndex];
            Console.WriteLine(RandomTaunt);
        }
    }
}