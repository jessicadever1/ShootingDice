using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Enter a number from 1-6");
            string ChoosenNumString = Console.ReadLine();
            int ChoosenNum = int.Parse(ChoosenNumString);
            return ChoosenNum;
        }
    }
}