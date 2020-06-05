using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            int groupSize;

            Console.WriteLine("What kind of trip would you like to go on: musical, tropical, or adventurous?");
            string vacationType = (Console.ReadLine());
            vacationType = vacationType.ToLower();
            //Check input for valid vacation types
            while (vacationType != "musical" && vacationType != "tropical" && vacationType != "adventurous")
            {
                Console.WriteLine("\nIncorrect Value. Please try again.");
                Console.WriteLine("What kind of trip would you like to go on: musical, tropical, or adventurous?");
                vacationType = (Console.ReadLine());
                vacationType = vacationType.ToLower();

            }



            Console.WriteLine("How many are in your group?");
            var input = Console.ReadLine();
            //check input for valid group size and ensure it's a whole number
            while(!int.TryParse(input, out groupSize) || groupSize <= 0)
            {
                Console.WriteLine("\nIncorrect Value. Please try again.");
                Console.WriteLine("How many are in your group?");
                input = Console.ReadLine();
            }


            string destination;
            if (vacationType == "musical")
            {
                destination = "New Orleans.";
            }
            else if (vacationType == "tropical")
            {
                destination = "a beach vacation in Mexico.";
            }
            else
            {
                destination = "a whitewater rafting vacation in the Grand Canyon.";
            }



            string travelMethod;
            if (groupSize >= 6)
            {
                travelMethod = "charter flight";
            }
            else if (groupSize >= 3)
            {
                travelMethod = "helicopter";
            }
            else
            {
                travelMethod = "first class flight";
            }

                   

            result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + travelMethod + " to " + destination;
            Console.WriteLine(result);

        }
    }
}
