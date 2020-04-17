using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4p2
{
    class Program
    {
        static void Main(string[] args)
        {
            // define variable for answering the math question
            int uGuess, numGuess, randNum;
            string repeat;

            do
            {
                //display instructions
                Console.WriteLine("We're going to play guess the number between 1-50" +
                    "and we'll play until you guess the right number.");

                //generate random number
                Random generator = new Random();
                randNum = generator.Next(1, 50);

                //numGuess is initiaed to 0
                numGuess = 0;

                //user choice
                Console.Write("What is your guess? ");

                //validate user choice
                do
                {
                    
                    uGuess = int.Parse(Console.ReadLine());
                    numGuess++;

                    if(uGuess<randNum)
                    {
                        Console.Write("Your guess is to low, guess again: ");
                    }
                    else if(uGuess>randNum)
                    {
                        Console.Write("Your guess is to high, guess again: ");
                    }
                    else if(uGuess==randNum)
                    {
                        Console.WriteLine("Correct guess! You got it in " +numGuess+ " guess!");
                    }

                } while (uGuess != randNum);

                //validates the if the user put Y or n and then moves to main loop.
                do
                {
                    Console.WriteLine("Do you want to play again?");
                
                    repeat = Console.ReadLine(); 
                    repeat = repeat.ToLower();

                    if (repeat != "y" && repeat != "n")
                    {
                        Console.WriteLine("Incorrect option please enter y or n");
                    }
                } while (repeat != "y" && repeat != "n");

            } while (repeat == "y");


            Console.ReadLine();
        }
    }
}
