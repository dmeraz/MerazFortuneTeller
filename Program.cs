using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerazFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for the user’s first name

            Console.WriteLine("Please type your first name and hit enter.");

            string firstName = Console.ReadLine();

            //Ask the user for the user’s last name

            Console.WriteLine("Please type your last name and hit enter.");

            string lastName = Console.ReadLine();

            //Ask the user for the user’s age 

            Console.WriteLine("Please type your age and hit enter.");

            int age = int.Parse(Console.ReadLine());

            //Ask the user for the user’s birth month(as an 'int')

            Console.WriteLine("Please type your birth month as a number from 1-12.");

            int birthMonth = int.Parse(Console.ReadLine());

            //Ask the user for the user’s favorite ROYGBIV color

            Console.WriteLine("Please type your favorite ROYGBIV color. If you do not know what ROYGBIV is, type \"Help\" and hit enter.");

            string favColor = Console.ReadLine();

            //Set conditional to branch for color vs "Help"

            //If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors

            //Ask the user for the number of siblings the user has

            Console.WriteLine("Please type the number of siblings you have and hit enter.");

            int siblings = int.Parse(Console.ReadLine());
        }
    }
}
