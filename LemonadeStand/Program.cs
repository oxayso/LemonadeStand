﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {     
            Game game = new Game();
            game.RunGame();
            Customer customer = new Customer();
            Player player = new Player();
            Pitcher lemonade = player.CustomizeLemonade();
            Console.ReadLine();           
        }
    }
}
