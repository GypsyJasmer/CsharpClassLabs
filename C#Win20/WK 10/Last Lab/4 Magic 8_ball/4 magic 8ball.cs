using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 4. Design and implement a program that simulates Magic 8-Ball.  The Magic 8-Ball is a plastic sphere made to look like an eight-ball, 
that is used for fortune-telling or seeking advice.  The program should allow a user to enter a question from the keyboard.  
The program should respond to the question by selecting one of 20 pre-programmed responses.  The user should be allowed to ask questions 
repeatedly in one program run.
 */

namespace _4_Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            string question;

            int answer; //answer is the 8 ball's replay to user's questions. 

            //string array of the 8 ball responses
            string[] response ={"I see it, yes." , "Ask again later.", "Better not tell you now.", "Cannot predict now." , " Concentrate and ask again.",
                "Don’t count on it.", "It is certain." , " It is decidedly so.", "Most likely.", "My reply is no.", " My sources say no.", "Outlook not so good.", "Outlook good.",
                "Reply hazy, try again.", " Signs point to yes.", "Very doubtful.", " Without a doubt.", "Yes.", " Yes – definitely.","You may rely on it." };

            Console.WriteLine("Ask a yes or no question and I will tell you your future. You can ask as many questions as you want and to stop type stop");
            question = Console.ReadLine();
            Random generator = new Random();

            while (question != "stop")
            {
                answer = generator.Next(0, response.Length);
                Console.WriteLine(response[answer]);

                //asks the user for another question until they type stop. 
                Console.WriteLine("Ask a yes or no question and I will tell you your future. You can ask as many questions as you want and to stop type stop");
                question = Console.ReadLine();

            }

            Console.ReadLine();
        }



    }
}
