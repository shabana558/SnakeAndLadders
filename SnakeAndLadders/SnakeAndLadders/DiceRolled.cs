﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    internal class DiceRolled
    {
        public static void dicerolled()
        {
        int playerPos = 0, rollDice;
        Random random = new Random();
        rollDice = random.Next(1, 7);
        Console.WriteLine("Rolled Dice number is:" + rollDice);

        }
    }
}