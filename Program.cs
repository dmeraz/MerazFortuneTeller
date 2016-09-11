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
            string retirementAge;

            if (age % 2 == 0)
            {
                retirementAge = "12 years";
            }
            else
            {
                retirementAge = "17 years";
            }

            //Ask the user for the user’s birth month(as an 'int')

            Console.WriteLine("Please type your birth month as a number from 1-12.");

            int birthMonth = int.Parse(Console.ReadLine());
            string moneyInBank;

            //Conditionals ordered based on most common birth months in US

            if (birthMonth >= 5 && birthMonth <= 8)
            {
                moneyInBank = "$6.5M";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                moneyInBank = "$500,000";
            }
            else if (birthMonth >= 1 && birthMonth <= 4)
            {
                moneyInBank = "$100,000";
            }
            else if (birthMonth > 1 || birthMonth < 12)
            {
                moneyInBank = "$0.00";
            }
            else
            {
                moneyInBank = "$0.00";
            }


            //Ask the user for the user’s favorite ROYGBIV color

            //If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors

            Console.WriteLine("Please type your favorite ROYGBIV color and hit enter. If you do not know what ROYGBIV is, type \"Help\" and hit enter.");

            string favColor = Console.ReadLine();
            string transportMode;

            //Help! What's ROYGBIV?!

            if (favColor == "Help")
            {
                Console.WriteLine("According to Wikipedia, ROYGBIV or Roy G. Biv is an acronym" +
                    " for the sequence of hues commonly described as making up a rainbow:" +
                    " red, /n orange, /n yellow, /n green, /n blue, /n indigo /n and violet." +
                    "/n Now, type your favorite ROYGBIV color and hit enter.");
            }
            else
            {
                //program continues
            }

            if (favColor == "red")
            {
                transportMode = "space ship";
            }
            else if (favColor == "orange")
            {
                transportMode = "train";
            }
            else if (favColor == "yellow")
            {
                transportMode = "tractor";
            }
            else if (favColor == "green")
            {
                transportMode = "teleportation machine";
            }
            else if (favColor == "blue")
            {
                transportMode = "DUKW";
            }
            else if (favColor == "indigo")
            {
                transportMode = "sports car";
            }
            else if (favColor == "violet")
            {
                transportMode = "pirate ship";
            }
            else { }

            //Ask the user for the number of siblings the user has

            Console.WriteLine("Please type the number of siblings you have and hit enter.");

            int siblings = int.Parse(Console.ReadLine());
            string vacaHome;

            if (siblings == 0)
            {
                vacaHome = "Alaska";
            }
            else if (siblings == 1)
            {
                vacaHome = "Upstate New York";
            }
            else if (siblings == 2)
            {
                vacaHome = "Hawaii";
            }
            else if (siblings == 3)
            {
                vacaHome = "Costa Rica";
            }
            else if (siblings > 3)
            {
                vacaHome = "Costa Rica";
            }
            else
            {
                vacaHome = "Sahara Desert";
            }

            //The user’s fortune should be written as such:
            //[First Name][Last Name] will retire in [# of Years] with [Amount of Money] in the bank,
            //a vacation home in [Location] and a [Mode of Transportation].

            Console.WriteLine(string.Concat(firstName + " " + lastName + " " + "will retire in " + retirementAge
                + " with " + moneyInBank + " in the bank, a vacation home in " + vacaHome + ", "
                + "and a " + transportMode + "."));

        }
    }
}
