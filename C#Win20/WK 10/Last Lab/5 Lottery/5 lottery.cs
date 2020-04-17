using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_winningTicket
{
    class Program
    {
        //Global const
        const int SIZE = 6;
        const int MIN = 1;
        const int MAX = 70;
        const int PB_INDEX = 5;
        const int PB_MIN = 1;
        const int PB_MAX = 27;

        static void Main(string[] args)
        {

            int[] winningTicket; //winning array ticket
            int[] userTicket; //user loto numbers array ticket
            int matches, pbMatches;
            string prize;


            winningTicket = new int[SIZE]; //dynamic memory new array to the heap
            userTicket = new int[SIZE]; //dynamic memory new array

            GetWinningTicket(winningTicket);
            DisplayTicket(userTicket, winningTicket);
            Console.WriteLine(); //space in the results shown
            GetTicket(userTicket);
            DisplayTicket(userTicket, winningTicket);
            Console.WriteLine(); //space in the results shown
            matches = CountMatches(userTicket, winningTicket);

            //check PB_INdex for the powerball number match and then totaling matches
            if (winningTicket[PB_INDEX] == userTicket[PB_INDEX])
            {
                pbMatches = 1;
            }
            else
            {
                pbMatches = 0;
            }
            //displays the matches of the userticket and the winning ticket with PB kicker being the extra match
            Console.Write("Matches: " + matches);
            Console.WriteLine(); //space in the results shown
            Console.Write("PowerBall/Kicker Match: " + pbMatches);
            Console.WriteLine(); //space in the results shown


            //Prizes outlined
            prize = GetTicketValue(matches, pbMatches);
            DisplayResults(prize);


            Console.ReadLine();
        }// end Main

        //computer ticket that is one array of 6 inedx = 0-4 are filled w/ rand 1-69 index =5 is filled with rand 1-26 we will return the winning ticket array
        static void GetWinningTicket(int[] winningTicket)
        {
            int winningTicketNum = 0;
            Random rand = new Random();

            //or i<winningTicket.length
            for (int i = 0; i < PB_INDEX; i++)
            {
                winningTicketNum = rand.Next(MIN, MAX);
                winningTicket[i] += winningTicketNum;

                //Console.WriteLine(winningTicketNum);

            }

            winningTicket[PB_INDEX] = rand.Next(PB_MIN, PB_MAX);



        }


        //called in GetTicket only
        static void GetTicket(int[] userTicket)
        {

            for (int i = 0; i < SIZE - 1; i++)
            {
                Console.Write("Enter 5 lottery numbers between 1 and 69: ");
                userTicket[i] = int.Parse(Console.ReadLine());

            }

            Console.Write("Enter 5 lottery numbers between 1 and 26: ");
            userTicket[PB_INDEX] = int.Parse(Console.ReadLine());

        }

        static void DisplayTicket(int[] userTicket, int[] winningTicket)
        {
            Console.Write("Your Ticket is: ");

            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(userTicket[i] + " ");
            }

            Console.WriteLine(); //space in the results shown

            Console.Write("Your winning ticket is: ");
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(winningTicket[i] + " ");
            }
        }
        //counts the total matches between userTicket ticket vs winning ticket up to index 5 Powerball number is compared in main
        static int CountMatches(int[] userTicket, int[] winningTicket)
        {
            int matches = 0;

            for (int i = 0; i < SIZE - 1; i++)
            {
                int valueFromUserTicket = userTicket[i];
                if (HasNumber(winningTicket, valueFromUserTicket))
                {
                    matches++;
                }
            }

            return matches;
        }

        //does the bool linera search that says yes or number if numbers are in both arrays 
        static bool HasNumber(int[] winningTicket, int valueFromUserTicket)
        {

            //foreach (int numInWin in winningTicket)
            for (int i = 0; i < SIZE - 1; i++)
            {
                int numInWin = winningTicket[i];
                if (valueFromUserTicket == numInWin)
                {
                    return true;
                }
            }
            return false;

        }


        static string GetTicketValue(int matches, int pbMatches)
        {
            string prize="";

            //$4 prize
            if (matches == 0 && pbMatches == 1 || matches == 1 && pbMatches == 1 )
            {
                prize = "prize1";
            }

            //$7 prize
            else if (matches == 2 && pbMatches == 1 || matches == 3 && pbMatches == 0)
            {
                prize = "prize2";
            }

            //$100 prize
            else if (matches == 3 && pbMatches == 1|| matches == 4 && pbMatches == 0)
            {
                prize = "prize3";
            }

            //$50K prize
            else if (matches == 4 && pbMatches == 1)
            {
                prize = "prize4";
            }
 
            //$100K prize
            else if (matches == 5 && pbMatches == 0)
            {
                prize = "prize5";
            }

            //biggest winner Jackpot
            else if (matches == 5 && pbMatches == 1)
            {
                prize = "jackpot";
            }

            return prize;

        }

        static void DisplayResults(string prize)
        {
                switch (prize)
            {
                case "prize1":
                    Console.WriteLine("You won $4.00");
                    break;
                case "prize2":
                    Console.WriteLine("You won $7.00");
                    break;
                case "prize3":
                    Console.WriteLine("You won $100.00");
                    break;
                case "prize4":
                    Console.WriteLine("You won $50,000");
                    break;
                case "prize5":
                    Console.WriteLine("You won $100,000");
                    break;
                case "jackpot":
                    Console.WriteLine("You won the $1,000,000 JACKPOT!!!!!!!!!!!!");
                    break;
                default:
                    Console.WriteLine("Sorry you are not a winner");
                    break;
            }


        }








    }

}
