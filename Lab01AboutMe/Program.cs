using System;

namespace Lab01AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            FavColor();
            SingleChildBoolean();
            NumOfDogs();
        }

        static string FavColor()
        {
            // ask user first question in console.
            Console.WriteLine("What is my favorite color?");
            // read what the user input
            string color = Console.ReadLine();

            // if conditional
            // 
            // will return 'is correct' if one of three colors
            // else 
            // will return 'is wrong' if not one of the above three
            return "";
        }

        static bool SingleChildBoolean()
        {
            Console.WriteLine("Do I have siblings? True or False, ONLY.");
            // read user input

            // if conditional
            // if true return true response
            // else
            // if false return false response
            return false;
        }

        static string NumOfDogs()
        {
            Console.WriteLine("Do I have dogs?");
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
