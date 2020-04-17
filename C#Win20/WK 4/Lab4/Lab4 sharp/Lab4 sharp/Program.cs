using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int uNum;

            Console.WriteLine("Please enter a number and I'll tell you whether it's a prime number.");
            Console.Write("Number: ");
            uNum = int.Parse(Console.ReadLine());

            int counter = 0;

            //for loop to validate if the number is prime
            for(int i=1; i <=uNum; i++)
            {
                if(uNum % i == 0)
                {
                    counter++;
                }
            }

            //display if prime or not
            if (counter == 2)
            {
                Console.WriteLine(uNum + " is a prime number.");
            }
            else
            {
                Console.WriteLine(uNum + " is NOT a prime number.");
            }

            Console.ReadLine();
        }
    }
}
