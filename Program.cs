﻿using System;
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
            Console.WriteLine("\aWelcome to Madam Meraz's portal for predictions.\nHit enter to continue.");
            Console.ReadLine();

            //Ask the user for the user’s first name

            Console.WriteLine("\nPlease type your first name and hit enter.");

            string firstName = Console.ReadLine();

            //Ask the user for the user’s last name

            Console.WriteLine("\nPlease type your last name and hit enter.");

            string lastName = Console.ReadLine();

            //Ask the user for the user’s age 

            Console.WriteLine("\nPlease type your age and hit enter.");

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

            Console.WriteLine("\nPlease type your birth month as a number from 1-12.");

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

            Console.WriteLine("\nPlease type your favorite ROYGBIV color and hit enter. \n If you do not know what ROYGBIV is, type \"Help\" and hit enter.");

            string favColor = Console.ReadLine();
            favColor.ToLower();
            string transportMode = "";

            //Help! What's ROYGBIV?!

            if (favColor.ToLower() == "help")
            {
                Console.WriteLine("\nAccording to Wikipedia, ROYGBIV or Roy G. Biv is an acronym" +
                    " for the sequence of hues commonly described as making up a rainbow:" +
                    " \n red, \n orange, \n yellow, \n green, \n blue, \n indigo \n and violet. \n" +
                    "Now, type your favorite ROYGBIV color and hit enter.");
                favColor = Console.ReadLine();
                favColor.ToLower();
            }

            //else
            //{
            //    //program continues
            //}

            switch (favColor.ToLower())
            {
                case "red":
                    transportMode = "space ship";
                    break;
                case "orange":
                    transportMode = "train";
                    break;
                case "yellow":
                    transportMode = "tractor";
                    break;
                case "green":
                    transportMode = "teleportation machine";
                    break;
                case "blue":
                    transportMode = "DUKW";//amphibious military vehicle commonly used in tourist attractions
                    break;
                case "indigo":
                    transportMode = "sports car";
                    break;
                case "violet":
                    transportMode = "pirate ship";
                    break;
            }
            

            //Ask the user for the number of siblings the user has

            Console.WriteLine("\nPlease type the number of siblings you have and hit enter.");

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

            Console.WriteLine(string.Concat("\n" + firstName + " " + lastName + " " + "will retire in " + retirementAge
                + " with " + moneyInBank + " in the bank, \n" + "a vacation home in " + vacaHome + ", "
                + "and a " + transportMode + ".\n"));

        }
    }
}
