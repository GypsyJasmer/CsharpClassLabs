/*Design and implement a program that asks the user to enter a non-zero positive number and determines 
if a number entered by the user is a prime number.  A prime number is a number that is divisible only by 
1 and itself.  2, 3, 5 and 7 are prime numbers.  4 and 9 are not prime numbers.  The program should validate 
the input in a reasonable way.  The program should ask the user if he/she/they want to check another number 
after the result has been displayed and should repeat the process as long as the user enters yes.
Methods:
    -GetInt
    -IsPrime
    -Display?
    -PlayAgain

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulStuff;

namespace Zero_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            do
            {
                number = GetPosInts();
                Result(number);
                Console.ReadLine();


            } while (PlayAgain.DoPlayAgain());
        }

        static int GetPosInts()
        {
            bool isInt = false;
            int number;
            do
            {
                Console.Write("Please enter a positive whole number: ");
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out number);
            } while (!(isInt && number > 0));

            return number;
        }

        static void Result(int number)
        {
            int count = 0;
            //for loop to validate if the number is prime //funtion is prime
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;

                }
            }
                if (count == 2)
                {
                    Console.WriteLine(number + " is a prime number.");
                }
                else
                {
                    Console.WriteLine(number + " is NOT a prime number.");
                }

          
        }

     

        
    }
}
