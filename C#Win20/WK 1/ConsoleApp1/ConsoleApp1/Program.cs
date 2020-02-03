using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Create a console application (with comments in your code that illustrate your understanding of what you've written) in both dotnetfiddle 
AND Visual Studio for each of the follow problem descriptions:

    Write a console app that asks the user for his/her/their name and then displays a welcome message that uses the user's name.  
    Write a console app that ask the user to enter his/her/their name, his/her/their age, the name of a city, the name of a college, 
    a profession, a type of animal and a pet's name.  Each of the strings entered by the user should be stored in a different variable.  
    Each variable should have an appropriate name.  After the user has entered these items, the program should display the following story, 
    inserting the user's input in the appropriate locations:

There once was a person named NAME who lived in a CITY.  At the age of AGE, NAME went to COLLEGE.  
NAME graduated and went to work as a PROFESSION.  Then, NAME adopted a ANIMAL named PETNAME.  They both lived happily ever after! The end.
*/

namespace wk1Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, city, college, job, animal, petName;
            int age;

            //asking user for name 
            Console.WriteLine("What is your name?");
            //declaring the string variable
            name = Console.ReadLine();
            Console.WriteLine("Hello: " + name);

            //asking for age
            Console.WriteLine("What is your age?");
            //declaring integer varaible and Convert.ToInt32 to not have an error in code due to Type casting. 
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            Console.WriteLine("What city do you live in? ");
            //back to string since the varaible is not a whole number.
            city = Console.ReadLine();
            Console.WriteLine("You live in:" + city);

            Console.WriteLine("Where do/did you go to college? ");
            //back to string since the varaible is not a whole number.
            college = Console.ReadLine();
            Console.WriteLine("Your higher education came from: " + college);

            Console.WriteLine("What is your profession or desired profession?");
            //back to string since the varaible is not a whole number.
            job = Console.ReadLine();
            Console.WriteLine(name + " are/want to be a(n)" + job);

            Console.WriteLine("What type of animal do you have or want? ");
            //back to string since the varaible is not a whole number.
            animal = Console.ReadLine();
            Console.WriteLine("Your animal is a(n)" + animal);

            Console.WriteLine("What is your pet's name?");
            //back to string since the varaible is not a whole number.
            petName = Console.ReadLine();
            Console.WriteLine("Your pet's name is " + petName);

            Console.WriteLine("There once was a person named " + name + " who lived in " + city +
                ". At the age of " + age +", " + name + " went to " + college +
                ". When " + name + " graduated and went to work as a " + job + ". Then, " + name +
                " adopted a " + animal + " named " + petName + ". They both lived happily ever after! The end.");



         Console.ReadLine();
        }
    }
}
