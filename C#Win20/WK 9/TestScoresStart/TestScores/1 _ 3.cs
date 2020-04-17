using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        /*  1.==============================================================================================
            Design and implement a program that processes a set of test scores.The user will enter scores
            in a range of 0 - 100 (invalid input will be ignored) from the keyboard and will enter -1 for the
            score when data entry is complete.The application will then calculate the average score, the
            lowest score and the highest score and display all 3 pieces of output on the screen.

            Input:
                set of test scores
            Process:
                get scores
                calculate averageScore
                calculate minScore
                calculate maxScore
                display averageScore, minScore, maxScore
            Output:
                averageScore
                minScore
                maxScore

        */

        //const int SIZE = 5;
        //const int MIN = Int32.MaxValue;
        //const int Max= Int

        static void Main(string[] args)
        {
            const int SIZE = 5;
            int numScores = 0;
            int[] scores = new int[SIZE];
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int total = 0;
            double average = 0;
            
            // get all of the scores
            int score = GetInt("score", -1, 100);
            while (score != -1 && numScores < scores.Length)
            {
                scores[numScores] = score;
                numScores++;
                if (numScores != scores.Length)
                    score = GetInt("score", -1, 100);
            }

            // only do the rest when the user actually entered scores
            if (numScores > 0)
            {
                // print them out
                for (int i = 0; i < numScores; i++)
                    Console.WriteLine("Score {0} is: {1}", i + 1, scores[i]);

                // calculate the average
                for (int i = 0; i < numScores; i++)
                    total += scores[i];
                average = (double)total / numScores;
                Console.WriteLine("The average is " + average.ToString("n2"));

                // now use a for each loop
                total = 0;
                foreach (int aScore in scores)
                    total += aScore;
                average = (double)total / numScores;
                Console.WriteLine("The average with a foreach loop is " + average.ToString("n2"));

                // find the lowest
                for (int i = 0; i < numScores; i++)
                    if (scores[i] < min)
                        min = scores[i];
                Console.WriteLine("The lowest number is " + min);

                // TODO:  find the highest
                max = GetHigest(scores, numScores);
                Console.WriteLine("The biggest number is " + max);

                // TODO:  count the number of times that the highest score occurrs

                // TODO:  is there a 76 in the array?

                // TODO:  where (at what index) is the 76?

                // TODO:  convert to methods

            }
            Console.ReadLine();

        } // end main

        static int GetInt(string label, int min, int max)
        {
            bool isInt = false;
            int number = min - 1;
            do
            {
                Console.Write(String.Format("Please enter a whole number between {0} and {1} for {2}: ", min, max, label));
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out number);
            } while (!(isInt && number >= min && number <= max));

            return number;
        }

        static void GetScores(int[] scores, out int numScores)
        {
            numScores = 0;
            int score = GetInt("score", -1, 100);
            while (score != -1 && numScores < scores.Length)
            {
                scores[numScores] = score;
                numScores++;
                if (numScores != scores.Length)
                    score = GetInt("score", -1, 100);
            }
        }

        static void DisplayScores(int[] scores, int numScores)
        {
            for (int i = 0; i < numScores; i++)
                Console.WriteLine("Score {0} is: {1}", i + 1, scores[i]);
        }

        static double GetAverage(int[] scores, int numScores)
        {
            int total = 0;
            for (int i = 0; i < numScores; i++)
                total += scores[i];
            double average = (double)total / numScores;
            return average;
        }

        static int GetLowest(int[] scores, int numScores)
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < numScores; i++)
                if (scores[i] < min)
                    min = scores[i];
            return min;
        }

        // TODO:  Write GetHighest
        static int GetHigest(int[] scores, int numScores)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < numScores; i++)
                if (scores[i] > max)
                    max = scores[i];
            return max;
        }


        // TODO:  Write a method that generates the scores randomly

        // TODO:  Write a method that counts the number of times a number occurs in the array

        // TODO:  Write a method that tells you whether or not a number is in an array

        //  TODO:  #1 in the lab  
        /*  Write a method that shuffles an array
            for each element in the array
                rndIndex = a random number between 0 and one less than the number of elements in the array
                swap the element at the current index with the element at the random index
            */
            static void SuffleArray(int[] scores)
        {
            Random rndIndex= new Random;

            for(int i=0;i<scores.Length; i++)
            {
                Swap(scores, i, i + rndIndex.Next(scores.Length - i));
            }


        }
        //swap element in the current index w/ the element at the random index
        static void Swap(int[] scores, int a, int b)
        {
            int temp = scores[a];
            scores[a] = scores[b];
            scores[b] = temp;
        }




        //  TODO:  #2 in the lab
        //  Write a method that uses a linear search to return the index of an element in an array
        /*  Algorithm - https://www.tutorialspoint.com/data_structures_algorithms/selection_sort_algorithm.htm
            for each element in the array starting at the first and continuing to next to the last - use i as index
                indexOfMin = i
                for each element in the array starting at the next and continuing to the end - use j as index
                    if current element < element at indexOfMin
                        indexOfMin = index of current element - j
                    end if
                end for
                swap element at indexOfMin with current element - i
            end for
        */
        static void IndexOfElement(int[] scores, )
        {
            //linera search 


            //swapper
            {
                int temp = scores[a];
                scores[a] = scores[b];
                scores[b] = temp;
            }
        }
        



        //  TODO:  #3 in the lab  
        //  Write a method that uses a linear search to return the index of a number in a given array  
        //  It should return -1 when the number is not in the array
        static int IndexOfLinerar(int[]scores, int numScores, int search)
        {
            int indexOfSearch = -1;
            for(int i=0; i<numScores && indexOfSearch == -1; i++)
            {
                if(scores[i] == search)
                {
                    indexOfSearch = i;
                }
            }

            return indexOfSearch;
        }
        //  Write a method that uses a binary search to return the index of a number in a given array
        /*  Algorithm - https://www.tutorialspoint.com/data_structures_algorithms/binary_search_algorithm.htm
                lowerBound = 0
                upperBound = sizeOfArray 
                found = false
                done = false
                index = -1
                while not found && not done
                    if upperBound < lowerBound 
                        done
                    else
                        midPoint = lowerBound + ( upperBound - lowerBound ) / 2
                        if A[midPoint] < x
                            lowerBound = midPoint + 1
                        else if A[midPoint] > x
                            set upperBound = midPoint - 1 
                        else // if A[midPoint] = x 
                            found = true
                            index = midPoint
                        end if
                    end if
                end while 
            */

    }
}
