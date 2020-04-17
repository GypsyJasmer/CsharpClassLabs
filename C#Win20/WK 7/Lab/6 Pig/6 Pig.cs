/*
 6. Design and implement a program that allows the user to play a version of the dice game Pig against the computer.  
The object of the game is to be the first to score 100 points.  The user and the computer take turns rolling a pair of dice following these rules:

            On a turn each player rolls 2 dice.  If no 1 appears, the total of the dice is added to the player's score and the 
			player can choose to roll again or pass the turn to the other player.  When it the computer does not roll a 1, 
			decide if the computer wants to roll again by generating a random number between 1 and 2.  1 causes the computer to roll again.  
			2 causes the computer to pass.
			
				If a 1 appears on one of the dice, nothing is added to the player's score and the player's turn is over.

				If a 1 appears on both dice, the player's score is reset to 0 and the player's turn is over.

				Here's a structure chart for my solution:  https://drive.google.com/open?id=153wAfFxeETTyyHLpnpupoMhSEMoV_ggL
 Input:
 Output:
 Process:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulStuff;


namespace _6_Pig
{
    class Program
    {
        //global const
        const int USER = 1;
        const int COMPUTER = 2;
        const int WINNING_SCORE= 25;

        static void Main(string[] args)
        {


            int userScore = 0, computerScore = 0;
            int winner;
           

            Console.WriteLine("Let's Play Pig!");
            Console.WriteLine();

            do
            {
                TimingStuff.Pause();
                UserPlay(ref userScore);
                Console.WriteLine();
                if (userScore < WINNING_SCORE)
                {
                    TimingStuff.Pause();
                    ComputerPlay(ref computerScore);
                    Console.WriteLine();
                }
            } while (userScore < WINNING_SCORE && computerScore < WINNING_SCORE);

            TimingStuff.Pause();
            Console.WriteLine();
            winner = DetermineWinner(userScore, computerScore);
            DisplayResults(winner, userScore, computerScore);

            Console.ReadLine();

        }

        //in/out userScore 
        static void UserPlay(ref int userScore)
        {
            //do while with Playagain? return string
            //in/out userScore ref
            //calls Play Again and play again isn't called in Main

            // creates an object called generator that can generate a random number
            Random generator = new Random();
            int d1, d2;
            bool playAgain;


            do {
                playAgain = false;

                //d1 & d2 random number between 1-6
                d1 = generator.Next(1, 7);
                d2 = generator.Next(1, 7);

                //display rolls, d1 & d2
                Console.WriteLine("Dice 1 rolled: " + d1);
                Console.WriteLine("Dice 2 rolled: " + d2);

                //conditions
                //no 1's rolled 
                if(d1!=1 && d2!=1)
                {
                    userScore += (d1 + d2);
                    Console.WriteLine("Your score is " + userScore);
                    playAgain=PlayAgain.DoPlayAgain();
                }
                //if user didn't win ask to roll again
                else if(d1==1 && d2==1)
                {
                    userScore = 0;      
                    Console.WriteLine("Your score is " + userScore);

                }
                //display that it's now the computer's turn
                else
                {
                    Console.WriteLine("Your score is " + userScore);
                    //display that it's now the computer's turn
                    Console.WriteLine("It's the computers turn");
                }

                 } while (playAgain==true);
        }

        //in/out computerScore 
        static void ComputerPlay(ref int comptuerScore)
        {

            //in/out comptuerScore ref
            //calls computer playAgain (seperate function) that is a random die that rolls a 1 or two. 

            // creates an object called generator that can generate a random number
            Random generator = new Random();
            int d1, d2;
            bool playAgain;


            do
            {
                playAgain = false;

                //d1 & d2 random number between 1-6
                d1 = generator.Next(1, 7);
                d2 = generator.Next(1, 7);

                //display rolls, d1 & d2
                Console.WriteLine("Dice 1 rolled: " + d1);
                Console.WriteLine("Dice 2 rolled: " + d2);

                //conditions
                //no 1's rolled 
                if (d1 != 1 && d2 != 1)
                {
                    comptuerScore += (d1 + d2);
                    Console.WriteLine("The computer's score is " + comptuerScore);
                    playAgain = GetCompPlayAgain();
                }
                //if user didn't win ask to roll again
                else if (d1 == 1&& d2 == 1)
                {
                    comptuerScore = 0;
                    Console.WriteLine("The computer's score is " + comptuerScore);

                }
                //display that it's now the computer's turn
                else
                {
                    Console.WriteLine("The computer's score is " + comptuerScore);
                    //display that it's now the computer's turn
                    Console.WriteLine("It's the users turn");
                }

            } while (playAgain == true);

        }

        //in userScore, in computerScore, return winner
        static int DetermineWinner(int userScore, int computerScore)
        {

            int winner;

            if(userScore>computerScore)
            {
                winner = USER;
            }
            else
            {
                winner = COMPUTER;
            }

            return winner;
        }

        //in winner, userScore, compScore
        static void DisplayResults(int winner, int userScore, int computerScore)
        {
            if(winner==USER)
            {
                Console.WriteLine("You won with  " + userScore + " score");
            }
            else
            {
                Console.WriteLine("Computer is the winner with " + computerScore+ " score");
            }
        }

        static bool GetCompPlayAgain()
        {
            // creates an object called generator that can generate a random number
            Random generator = new Random();

            int d3;

            //d1 & d2 random number between 1-6
            d3 = generator.Next(1, 3);

                if (d3==1) 
                {
                    return true;
                }
                else
                {
                    return false;
                }

        }
    }
}
