
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            // define variable for answering the math question
            const int ROCK=1, PAPER=2, SCISSORS = 3;
            int uChoice, cChoice;

            //display instructions
            Console.WriteLine("We're going to play Rock, Paper, Scissors. " +
                "You will be playing with a computer and entering 1 for rock, 2 for paper, or 3 for scissors." +
                "Let's get going");

            //get user choice
            uChoice = int.Parse(Console.ReadLine());

            //generate random computer choice
            Random generator = new Random();
            cChoice = generator.Next(1, 4);

            //displaying what computer picked
               if(cChoice==ROCK)
            {
                Console.WriteLine("Computer picked ROCK " +cChoice);
            }
            else if (cChoice==SCISSORS)
            {
                Console.WriteLine("Computer picked SCISSORS " +cChoice );
            }
            else
            {
                Console.WriteLine("Computer picked PAPER " + cChoice);
            }
            


            //verify tie, win, or draw and display message. 
            if (uChoice==cChoice)
            {
                Console.WriteLine("You tied with the computer");
            }
            else if(uChoice==ROCK && cChoice == SCISSORS ||
                    uChoice==SCISSORS && cChoice==PAPER ||
                    uChoice==PAPER && cChoice==ROCK)
            {
                Console.WriteLine("You won!!");
            }
            else
            {
                Console.WriteLine("Computer won!!");
            }




            Console.ReadLine();

        }
    }
}
