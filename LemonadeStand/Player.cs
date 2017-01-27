﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string name;
        
        public virtual void GetPlayerName()
        {
            Console.WriteLine("\nType your name below to start your business! PRESS [ENTER]");
            name = Console.ReadLine();
        }

        public void PrintPlayerName()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{name}, get ready to make some money! ... or prepare to lose some.");
            Console.ResetColor();
        }
    }
}
