﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Variaveis
    {
        static void Main(string[] args)
        {
            /*
            int x, y;

            x = 8;
            y = x + 2;

            Console.WriteLine(y);
            Console.ReadLine();
            
            */

            Console.WriteLine("What is your Name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine();

            //Console.Write("Type your last name: ");
            //string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}
