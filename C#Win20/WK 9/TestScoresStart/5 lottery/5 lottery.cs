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

            winningTicket = new int[SIZE]; //dynamic memory new array to the heap
            userTicket = new int[SIZE]; //dynamic memory new array
         
            GetWinningTicket(winningTicket);
            GetTicket(userTicket);
            

            //DisplayTicket();
            //CountMatches();
            //HasNumber();
            //GetTicketValue();
            //DisplayResults();

            Console.ReadLine();
        }// end Main

        //computer ticket that is one array of 6 inedx = 0-4 are filled w/ rand 1-69 index =5 is filled with rand 1-26 we will return the winning ticket array
        static void GetWinningTicket(int[] winningTicket)
            { 
            int winningTicketNum = 0;
            Random rand = new Random();

            //or i<winningTicket.length
            for(int i=0; i<PB_INDEX;i++ )
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


        static void DisplayTicket(int[] userTicket)
        {
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(userTicket[i] + " ");
            }
        }

        //counts the total matches between userTicket ticket vs winning ticket 
        static int CountMatches(int[] userTicket, int[] winningTicket)
        {
            int matches = 0;
            foreach(int valueFromUserTicket in userTicket)
            {
                if(HasNumber(winningTicket, valueFromUserTicket))
                {
                    matches++;
                }
            }

            return matches;
        }

        //does the bool linera search that says yes or number if numbers are in both arrays 
        static bool HasNumber(int[] winningTicket, int valueFromUserTicket)
        {
           foreach(int numInWin in winningTicket)
            {
                if(valueFromUserTicket==numInWin)
                {
                    return true;
                }
            }
            return false;
          
        }


        static decimal GetTicketValue(int matches, int powerballMatches)
        {
            return decimal;
        }

        
  
            


    }
}
