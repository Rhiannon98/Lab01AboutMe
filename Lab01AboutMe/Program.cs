using System;

namespace Lab01AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            FavColor();
            /*SingleChildBoolean();
              NumOfDogs(); */
        }

        static string FavColor()
        {
            // ask user first question in console.
            Console.WriteLine("what is my favorite color?");
            // read what the user input
            string colorString = Console.ReadLine();
            string[] favColorStrings = new string[3];
            favColorStrings[0] = "black";
            favColorStrings[1] = "blue";
            favColorStrings[2] = "purple";

            if (colorString == favColorStrings[0] || colorString == favColorStrings[1] ||
                colorString == favColorStrings[3])
            {
                Console.WriteLine("correct! i have three actually; blue, black and purple");
            }
            else
            {
                Console.WriteLine("WRONG!");
            }

            return "did you try?";
        }

        static bool SingleChildBoolean()
        {
            Console.WriteLine("do i have siblings? true/false, ONLY.");
            // read user input
            // if conditional
            // if true return true response
            // else
            // if false return false response
            return false;
        }

        static string NumOfDogs()
        {
            Console.WriteLine("do i have dogs?");
            // read user input

            // if yes
            // return great!
            // how large do you think my pack got?
            // else
            // return oooh too bad, the answer is a definite yes
            return "";
        }
    }
}