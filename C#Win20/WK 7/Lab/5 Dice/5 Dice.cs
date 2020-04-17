/*
5. Design and implement an application that allows the user to play a simple dice game.  
The game begins by allowing the user to pick a number between 2 and 12 (the possible sum of 2 dice).  
The computer will then roll 2 dice up to 3 times.  If the number chosen by the user comes up, the user wins and the game ends.  
If the number does not come up within 3 tries, the computer wins.  After the game has completed the program should allow the user to play again.  
The program should keep track of how many times the user wins and the computer wins.  

    Here's a structure chart for my solution:  https://drive.google.com/open?id=1De0qQO4ZVRvx7Lgm6qx8DjHj6bo55WwK
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulStuff;

namespace _5_Dice
{
    class Program
    {
        //global const
        const int USERWON=1;
        const int COMPUTERWON=2;
        const int MIN = 2;
        const int MAX = 12;

        static void Main(string[] args)
        {
            //local varaibles
            int userWins = 0;
            int computerWins = 0;
            int uNum, d1, d2, winner;

            // creates an object called generator that can generate a random number
            Random generator = new Random();

            do//loop to play again. 
            {
                uNum = GetInt("The total of two dice" , MIN, MAX);
                int compRand=PlayGame(uNum, out d1, out d2, generator);
                winner = DeterminWinner(uNum, compRand);
                IncrementScores(winner, ref userWins, ref computerWins);
                DisplayWinner(winner); //Mari's says pass ing userWins & ComputerWins


                

            } while (PlayAgain.DoPlayAgain());


            Console.ReadLine();
        }

        //Min and max const and returning users number
        static int GetInt(string label, int MIN, int MAX)
        {
            bool isInt = false;
            int uNum = MIN- 1;
            do
            {
                Console.Write(String.Format("Please enter a whole number between {0} and {1} for {2}: ", MIN, MAX, label));
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out uNum);
            } while (!(isInt && uNum >= MIN && uNum <= MAX));

            return uNum;
        }

        //play game 
        static int PlayGame(int uNum, out int d1, out int d2, Random generator)
        {
            int rolls = 0;
            
            do
            {
                d1 = generator.Next(1, 7);
                d2 = generator.Next(1, 7);

                //increment rolls
                rolls++;

                //display rolls, d1 & d2
                Console.WriteLine("Roll # " + rolls);
                Console.WriteLine("Dice 1 rolled: " + d1);
                Console.WriteLine("Dice 2 rolled: " + d2);

            } while (rolls < 3 && d1 + d2 != uNum);

            int compRand = d1 + d2;
            return compRand;
        }


        //sees if computer or user won
        static int DeterminWinner(int uNum, int compRand)
        {
            // who won
            if (uNum == compRand)
            {
                return USERWON;
            }
            else
            {
                return COMPUTERWON;
            }

            
        }

        static void DisplayWinner(int winner)
        {
            // who won
            if (winner==USERWON)
            {
                Console.WriteLine("YOU win!!");
            }
            else
            {
                Console.WriteLine("COMPUTER wins!!");
            }

        }

        // This method takes in as parameters winner, userWins and computerWins.
        // Because userWins and computerWins are altered by method, they're reference parameters rather than value parameters.
        // C# uses the keyword ref to indicate a reference parameter (out can be used too)
        // C# requires ref before the parameter in both the declaration and the call
        static void IncrementScores(int winner, ref int userWins, ref int computerWins)
        {
            if (winner == USERWON)
                userWins++;
            else if (winner == COMPUTERWON)
                computerWins++;
        }


    }
}
