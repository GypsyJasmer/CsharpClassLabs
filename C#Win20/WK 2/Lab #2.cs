using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
6. 2nd Grader
Input(nouns)
	mathAnswer

	
Processing(verbs)
	Generate random numbers
	Generate random numbers
	Display mathEquation
	Get mathAnswer
	Display sum

	
Output(nouns)
	mathEquation
	sum
    */

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variable for answering the math question
            int answer, sum, firstRand, secRand;

            //generate random number
            // creates an object called generator that can generate a random number
            Random generator = new Random();
            firstRand = generator.Next(1, 1000);

            //gernerate random number
            secRand = generator.Next(1, 1000);

            //display math equestion
            Console.WriteLine(String.Format("{0,5}", firstRand));
            Console.WriteLine(String.Format("+{0,4}", secRand));

            //get input of the math answer
            Console.Write("What is the sum of the equation? ");
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //calculate the sum
            sum = firstRand + secRand;

            //display the sum of the equation
            Console.WriteLine("The sum of the answer is:" +sum);



            Console.ReadLine();

        }
    }
}
