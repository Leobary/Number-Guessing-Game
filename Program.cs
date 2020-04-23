using System;
using System.Linq;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        { 
            // A number guessing game written in order to fulfill C# task in start.ng 2020
            Console.WriteLine("*** Welcome to LEOBARY Number Guessing Game ***");
            int number = 0;
            string level = "";
            Random num = new Random();      //Helps to generate random number
            
            Console.Write("\nSelect a level you wish to play ( EASY / MEDIUM / HARD ) : ");
            level = Console.ReadLine();      //Accepts the chosen level of the game

            // *** EASY LEVEL ***
            if (level == "EASY")
            {
                int guess = num.Next(1,10);     //generates a number between 1 and 10
                int count = 6;   //number of guesses available for this level
                
                while (number != guess)
                {
                    Console.Write("\nEnter any number between 1 and 10: ");
                    number = int.Parse(Console.ReadLine());
                    count--;

                    if (number == guess)
                    {
                        Console.WriteLine("\nYou got it right!");
                        Console.WriteLine("Congratulations WINNER!!!");
                        break;
                    }
                
                    Console.WriteLine("That was wrong!");
                    Console.WriteLine("You have " + count + " guesses left.");
                    if (count == 0)
                    {
                        Console.WriteLine("GAME OVER!!!");
                        break;
                    }
                }
            }
            // *** MEDIUM LEVEL ***
            else if (level == "MEDIUM")
            {
                int guess = num.Next(1,20);         //generates a number between 1 and 20
                int count = 4;          //number of guesses available for this level
                
                while (number != guess)
                {
                    Console.Write("\nEnter any number between 1 and 20: ");
                    number = int.Parse(Console.ReadLine());
                    count--;

                    if (number == guess)
                    {
                        Console.WriteLine("\nYou got it right!");
                        Console.WriteLine("Congratulations WINNER!!!");
                        break;
                    }
                
                    Console.WriteLine("That was wrong!");
                    Console.WriteLine("You have " + count + " guesses left.");
                    if (count == 0)
                    {
                        Console.WriteLine("GAME OVER!!!");
                        break;
                    }
                }
            }
            // *** HARD LEVEL ***
            else if (level == "HARD")
            {
                int guess = num.Next(1,50);         //generates a number between 1 and 50
                int count = 3;          //number of guesses available for this level
                
                while (number != guess)
                {
                    Console.Write("\nEnter any number between 1 and 50: ");
                    number = int.Parse(Console.ReadLine());
                    count--;

                    if (number == guess)
                    {
                        Console.WriteLine("\nYou got it right!");
                        Console.WriteLine("Congratulations WINNER!!!");
                        break;
                    }
                
                    Console.WriteLine("That was wrong!");
                    Console.WriteLine("You have " + count + " guesses left.");
                    if (count == 0)
                    {
                        Console.WriteLine("GAME OVER!!!");
                        break;
                    }
                }
            }       
        }
    }
}
