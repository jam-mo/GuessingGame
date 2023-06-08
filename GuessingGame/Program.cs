using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetNumber = new Random().Next(1, 100);
            int maxTries = 5;
            int currentTry = 1;

            Console.WriteLine("I'm thinking of a number between 1 and 99.");
            Console.WriteLine("You have 5 tries to guess it.");

            while (currentTry <= maxTries)
            {
                Console.Write("Enter your guess: ");
                int guessedNumber = Convert.ToInt32(Console.ReadLine());

                if (guessedNumber == targetNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    break;
                }
                else if (guessedNumber < targetNumber)
                {
                    Console.WriteLine("Nope, the number is higher.");
                }
                else
                {
                    Console.WriteLine("Nope, the number is lower");
                }

                currentTry++;
            }

            if (currentTry > maxTries)
            {
                Console.WriteLine("Sorry, you've run out of tries. The number I was thinking of was: " + targetNumber);
            }

            Console.WriteLine("Game Over!");
            Console.ReadLine();
        }
    }
}
