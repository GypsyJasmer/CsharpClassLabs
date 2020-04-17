using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester1
{
    class Tester
    {
        static void Main(string[] args)
        {

            //varaibles
            int uNum, rolls;

            //display instructions
            Console.WriteLine("Dice Game! You'll enter a number between 2 -12. " +
                "and then we roll the dice to see if your number matches the dice");

            //getting user input
            Console.Write("Please pick a number between 2 - 12: ");
            uNum = int.Parse(Console.ReadLine());


            // creates an object called generator that can generate a random number
            Random generator = new Random();

            //declaring d1 & d2
            int d1, d2;

            //initializing rolls to 0
            rolls = 0;

            //
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

            //who won
            if (uNum == d1 + d2)
            {
                Console.WriteLine("YOU win!!");
            }
            else
            {
                Console.WriteLine("COMPUTER wins!!");
            }



            Console.ReadLine();

        }
    }
}
