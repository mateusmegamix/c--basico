using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game:");

            Console.Write("What´s your first name? ");
            string FirstName = Console.ReadLine();

            Console.Write("What´s yourr last name? ");
            string LastName = Console.ReadLine();

             

            Console.Write("In what city were you born? ");
            string City = Console.ReadLine();

            DisplayResult(
                ReverseString(FirstName) + " " + 
                ReverseString(LastName) + " " +
                ReverseString(City));
            Console.ReadLine();

        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);

        }
        private static void DisplayResult(
            string reversedFirstName,
            string reversedLastName,
            string reversedCity)
        {
            Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }
        private static void DisplayResult(string message)
        {
            Console.Write("Result: ");
            Console.Write(message);
        }
        
    }
}
