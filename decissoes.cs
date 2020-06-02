using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Mathews Big Giveway");
            //Console.Write("Choose a door: 1, 2 or 3: ");
            //string userValue = Console.ReadLine();

            //string message = "";
            //if (userValue == "1")

            //    message = "You won a new car!";


            //else if (userValue == "2")

            //    message = "You won a new boat!";

            //else if (userValue == "3")

            //    message = "You won a new cat!";
            //    //string message = "You won a new cat!";

            //else
            //{
            //    message = "Sorry, we didn´t understand. ";
            //    message += "You Lose.";
            //    //quando tiver mais de uma linha usa-se chaves.
            //}
            //Console.WriteLine(message);
            //Console.ReadLine();

            Console.WriteLine("Mathews Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");

            Console.WriteLine("You entered: {0}, therefore you won a {1}.", message);

            Console.ReadLine();

        }
    }
}
