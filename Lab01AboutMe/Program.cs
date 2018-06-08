using System;
using static System.Console;

namespace Lab01AboutMe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Hello World!");
            FavColor();
            SingleChildBoolean();
            NumOfDogs(); 
        }

        public static string FavColor()
        {
            // ask user first question in console.
            WriteLine("what is my favorite color?");
            // read what the user input
            string colorString = ReadLine();
            string[] favColorStrings = new string[3];
            favColorStrings[0] = "black";
            favColorStrings[1] = "blue";
            favColorStrings[2] = "purple";

            if (colorString == favColorStrings[0] || colorString == favColorStrings[1] ||
                colorString == favColorStrings[3])
            {
                WriteLine("correct! i have three actually; blue, black and purple");
                Clear();
            }
            if (colorString != favColorStrings[0] || colorString != favColorStrings[1] || colorString != favColorStrings[2])
            {
                WriteLine("incorrect, my favorite colors are blue, black and purple!");
                Clear();
                return "moving on..";
            }

            return "good guesses :)";
        }

        public static void SingleChildBoolean()
        {
            WriteLine("do i have siblings? true/false, ONLY.");
            // read user input
            string userBool = ReadLine();
            // if conditional
            // if true return true response
            if (userBool == "true")
            {
                WriteLine("truth! i have one biological sister.");
                Clear();
            }
            else
            {
                WriteLine("nope, i actually have a sister!");
                Clear();
            }
        }

        public static void NumOfDogs()
        {
            WriteLine("do i have dogs? yes or no.");
            // read user input
            string userGuess = ReadLine();

            if (userGuess.ToLower() == "yes")
            {
                WriteLine("correct! i have two dogs right now :)");
                WriteLine("how large do you think was my largest pack?");
                int userGuess2 = Convert.ToInt32(ReadLine());

                if (userGuess2 == 5)
                {
                    WriteLine("yes! my family loves dogs :)");
                }
                if (userGuess2 < 5)
                {
                    WriteLine("oooh, too low. My largest was 5 pups in the pack at once!");
                }

                if (userGuess2 > 5)
                {
                    WriteLine("whoa there! im not THAT insane, its a kinda sensible number");
                }
                else
                {
                    WriteLine("its alright, this was optional :)");
                    Clear();
                    return;
                }

                Clear();
            }
            if (userGuess.ToLower() == "no")
            {
                WriteLine("incorrect, i do have two dogs right now.");
                Clear();
            }
            WriteLine("thats the end, hope you had some fun at least in this simple game.");
            Clear();
        }
    }
}