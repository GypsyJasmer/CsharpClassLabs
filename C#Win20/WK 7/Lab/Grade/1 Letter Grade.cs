using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int score1, score2, score3;
            string letterGrade;
            double aveScore, avePerctent;

            //calling GetScore and input to score
            score1 = GetScore();
            score2 = GetScore();
            score3 = GetScore();

            //math for the aveScore & avePercent to get the letterGrade 
            aveScore = (score1 + score2 + score3) / 3.0;
            avePerctent = aveScore / 50 * 100;

            //calling method DetermineLetterGrade and assigning the returned variable letterGrade
            letterGrade = DetermineLetterGrade(avePerctent);
            Console.WriteLine(letterGrade);


            Console.ReadLine();

        }

        static int GetScore()
        {
            // these are local variables
            // their scope is the method GetScore
            // they can only be used in this method
            bool isInt = false;
            int score;
            do
            {
                Console.Write("Please enter the score between 0-50: ");
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out score);
            } while (!(isInt && score >= 0 && score <= 50));

            // allows you to get a value out of a method
            // datatype must be an int
            return score;
        }

        static string DetermineLetterGrade(double avePercent)
        {
            string letterGrade;

            if (avePercent >= 90.0)
            {
                letterGrade = "A";
            }
            else if (avePercent >= 80.0)
            {
                letterGrade = "B";
            }
            else if (avePercent >= 70.0)
            {
                letterGrade = "C";
            }
            else
            {
                letterGrade = "F";
            }

            return letterGrade;

        }
    }
}
