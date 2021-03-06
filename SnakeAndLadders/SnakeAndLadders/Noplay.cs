using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    internal class Noplay
    {
        public static void noplay()
        {
            //local variable
            int rollDice, playerPos = 0;

            //To generate random number
            Random random = new Random();
            //List to check options
            var list = new List<string> { "No Play", "Ladder", "Snake" };

            //Conditions for user options
            rollDice = random.Next(1, 7);
            Console.WriteLine("Dice number is : " + rollDice);

            //Print user options
            Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake");

            //Use random to check user option
            int index = random.Next(list.Count);
            Console.WriteLine("Player option is : " + list[index]);
            if (playerPos + rollDice < 100)
            {
                if (list[index] == "Ladder") playerPos += rollDice;
                if (list[index] == "Snake") playerPos -= rollDice;
            }

            if (playerPos < 0)
            {
                playerPos = 0;
            }
            //Print to Console
            Console.WriteLine("\n");
            Console.WriteLine("Player current position : " + playerPos);
            Console.WriteLine("Final position is :" + playerPos);
        }
    }
}