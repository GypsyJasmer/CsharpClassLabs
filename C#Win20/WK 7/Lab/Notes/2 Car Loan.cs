/* 	2. Design and implement a program that can be used to provide users with information about the 
    monthly payment for a car loan.  The program should allow a user to enter the amount of the loan 
    and the annual interest rate.  The program should validate data entered by the user in a reasonable 
    way and should force the user to reenter until the data is correct.  The program should display 
    the monthly payment for a 4 year loan, a 5 year loan and a 6 year loan in an attractively formatted table.  
    The formula for calculating the payment is given at the right. 

        HINT:  Math.Pow can be used for exponentiation in C#.  double fourSquared = Math.Pow( 4, 2);  for example.

    *GetLoanAmount
        retun decimal loanAmount
    *GetInterestRate
        return double interestRate

    int months=years*12

    *CalcPayment (loanAmount, interestRate, years)

    payment=
        (rate per period * loan amount)
        math.Pow(1-(1+rate per period) - months)
        return decimal monthPayment
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossPay
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter your loan amount and your interest rate and I will caclucate your monthly payments for 48, 60, and 72 months.");

            double loanAmount = GetLoanAmount();
            double interestRate = GetInterestRate();

            Console.WriteLine("The Payment on you 48 month loan will be: " + CalcPayment(loanAmount, interestRate, 4) .ToString("C"));
            Console.WriteLine("The Payment on you 60 month loan will be: " + CalcPayment(loanAmount, interestRate, 5).ToString("C"));
            Console.WriteLine("The Payment on you 72 month loan will be: " + CalcPayment(loanAmount, interestRate, 6).ToString("C"));
           

            Console.ReadLine();
        }
        static double GetLoanAmount()
        {
            bool isDoub = false;
            double loanAmount;
            do
            {
                Console.Write("Please enter your loan amount that is $1,000.00 or more: ");
                string input = Console.ReadLine();
                isDoub = double.TryParse(input, out loanAmount);
            } while (!(isDoub && loanAmount>=1000) );

            return loanAmount;
        }

        static double GetInterestRate()
        {
            bool isDoub = false;
            double interestRate;
            do
            {
                Console.Write("Please enter your interest ratebetween 0%-20%: ");
                string input = Console.ReadLine();
                isDoub = double.TryParse(input, out interestRate);
            } while (!(isDoub && interestRate > 0 && interestRate<=20));

            //return the total term interest rate
            return interestRate;

        }

        static decimal CalcPayment(double loanAmount, double interestRate, double loanTerm)
        {
            loanTerm *= 12; //loanTerm=loanTerm*12
            double monthlyInterest = interestRate / 12 * .01; //this assumes 10% w/ .01
            
            //math from Mari for payment. 
            double payment = (monthlyInterest * loanAmount) / (1 - Math.Pow((1 + monthlyInterest),  -loanTerm));
	        
                
            return (decimal) payment;

        }
    }
}
