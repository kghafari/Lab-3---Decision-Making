using System;

namespace Lab_3___Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alright, let's do some Decision Making!");
            Console.WriteLine("First off, what's your name?");
            string userName = Console.ReadLine();

            string keepGoing = "y";
            while (keepGoing == "y")
            {
                Console.WriteLine($"Thanks {userName}! Please enter a number between 1-100");
                int userInput = int.Parse(Console.ReadLine());
                while (userInput <= 0 || userInput > 100)
                {
                    Console.WriteLine("ERROR: Please enter a number between 1 and 100");
                    userInput = int.Parse(Console.ReadLine());
                }
                //get odds
                if (userInput % 2 == 1)
                {
                    Console.WriteLine($"The number {userInput} is odd.");
                }
                //only evens left
                else if (userInput < 25)
                {
                    Console.WriteLine($"The number {userInput} is even, and less than 25.");
                }
                else if (userInput >= 26 && userInput <= 60)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine($"{userInput} is Even");
                }

                //prompt to keep going
                Console.WriteLine("Would you like to continue? (y/n)");
                keepGoing = Console.ReadLine();

                while (keepGoing != "y" && keepGoing != "n")
                {
                    Console.WriteLine("Please enter 'y' or 'n'.");
                    keepGoing = Console.ReadLine();
                }
            }
        }
    }
}
