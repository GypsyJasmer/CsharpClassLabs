/*
 4. Design and implement a program that allows the user to calculate the future value of an investment.  
The program should allow the user to enter the present value of the investment, the annual interest rate and the length of the investment.  
The program should validate the input in a reasonable way.  The program should display the future value of the investment and allow the 
user to enter a new set of data and repeat the process.

Input:
    Current investment
    annual interest
    term of investment
Output:
    investment amount

 Process:
    Calc investment (needs current investment, interest, and term)
    Display invesment (needs the total paid after investment term and the term)
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulStuff;

namespace _4_investment
{
    class Program
    {
        static void Main(string[] args)
        {
            do //loop to play again. 
            {
                double investment = GetInvestmentAmount();
                double interest = GetAnnualInerest();
                double term = GetTermOfInvestment();
                double money = CalculateInvestment(investment, interest, term);
                DisplayInvestment(money, term);




            } while (PlayAgain.DoPlayAgain());
        }


        //gets the amount the user will invest or want to could change to double
        static double GetInvestmentAmount()
        {
            bool isDoub = false;
            double investment=0;
            do
            {
                Console.Write("How much will you be investing: ");
                string input = Console.ReadLine();
                isDoub = double.TryParse(input, out investment);
            } while (!(isDoub && investment > 0));

            return investment;

        }

        //gets the interest rate for the investment //decimanl? 
        static double GetAnnualInerest()
        {
            bool isDoub = false;
            double interest;
            do
            {
                Console.Write("How much is the interest on your investment:  ");
                string input = Console.ReadLine();
                isDoub = double.TryParse(input, out interest);
            } while (!(isDoub && interest > 0));

            return interest;
        }

        //gets how long the invest will be in years to mautre
        static double GetTermOfInvestment()
        {
            bool isDoub = false;
            double term;
            do
            {
                Console.Write("How many years is your investment: ");
                string input = Console.ReadLine();
                isDoub = double.TryParse(input, out term);
            } while (!(isDoub && term > 0));

            return term;

        }

        //calculate investment but not diaplying only the math
        static double CalculateInvestment(double investment, double interest, double term)
        {
            //Total interest will calculate how much interest is paid over the full investment period
            double totalInterest = interest * term;

            //This calculate how much the investment will be after the total interest of the term and investment
            double money = investment * totalInterest;

            return money; //return money so money can be passed into display. 
        }

        //called to display the calculations of the investment
        static void DisplayInvestment(double money, double term)
        {
            //change the double to decimal show the 

            Console.WriteLine("The total income you will make in " + term + " years will be: " + money.ToString("C"));
        }

    }
}




