using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---------- Task 1 -----------*/
            /*---- Comparing Integers -----*/

            //Title
            Console.WriteLine("****************************");
            Console.WriteLine("********** Task 1 **********");
            Console.WriteLine("****************************");

            //Get the users input and save them to int variables
            Console.Write("Please enter a number: ");
            //note: The int.Parse() allows us to check if a string is a integer, in this case the console.readline() is the string.
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            //Use if, else if and else statements to check which is the larger of the two numbers.
            if (num1 == num2)
                Console.WriteLine("The two numbers you entered are equal.");
            else if (num1 > num2)
                //note: by putting the $ before the begining of the string I am able to access the variables inline.
                Console.WriteLine($"The first number entered, {num1}, is the larger of the two.");
            else
                Console.WriteLine($"The second number entered, {num2}, is the larger of the two.");

            //Give the user a meaningfull output to let them know this part is complete.
            Console.WriteLine("Task 2 finished. Please press enter to continue.....");
            //note: I've used this here to pause the program to allow the user to see the output
            Console.ReadLine();
            Console.Clear();

            /*------- End of Task 1 -------*/





            /*---------- Task 2 -----------*/
            /*------ Guess my Number ------*/

            //Title
            Console.WriteLine("****************************");
            Console.WriteLine("********** Task 2 **********");
            Console.WriteLine("****************************");

            //Set the number that the user has to try and guess. How could i make this random?
            int number = 7;

            //Tell the user what to do and save there input to a variable.
            Console.Write("Try and guess my number from 1 to 10: ");
            int guess = int.Parse(Console.ReadLine());

            //Use if, else if and else statements to check if they guessed right, to high or to low.
            if (guess == number)//The right answer
                Console.WriteLine("You got it, tu meke alright.");
            else if (guess > number)//guess was to high
                Console.WriteLine("Sorry your guess was to high");
            else//guess was to low
                Console.WriteLine("Sorry your guess was to low");

            //Give the user a meaningfull output to let them know this part is complete.
            Console.WriteLine("Task 2 finished. Please press enter to continue.....");
            //note: I've used this here to pause the program to allow the user to see the output
            Console.ReadLine();
            Console.Clear();

            /*------- End of Task 2 -------*/




            /*---------- Task 3 -----------*/
            /*---------- Grades -----------*/
            
            //Title
            Console.WriteLine("****************************");
            Console.WriteLine("********** Task 3 **********");
            Console.WriteLine("****************************");

            //Ask the user for there mark and stores it in a float variable(just incase they try to enter a decimal
            Console.Write("Please enter your final mark: ");
            float mark = float.Parse(Console.ReadLine());

            //Check ing the mark using if, else if and else statments
            if (mark >= 90 && mark <= 100)
                Console.WriteLine("Your grade is an A+");
            else if (mark >= 80 && mark <= 89)
                Console.WriteLine("Your grade is an A");
            else if (mark >= 70 && mark <= 79)
                Console.WriteLine("Your grade is a B+");
            else if (mark >= 60 && mark <= 69)
                Console.WriteLine("Your grade is a B");
            else if (mark >= 50 && mark <= 59)
                Console.WriteLine("Your grade is a C");
            else if (mark >= 40 && mark <= 49)
                Console.WriteLine("Your grade is a D");
            else if (mark >= 0 && mark <= 39)
                Console.WriteLine("Your grade is a F");
            else
                Console.WriteLine("There was a problem with the mark you entered");

            //Give the user a meaningfull output to let them know this part is complete.
            Console.WriteLine("Task 3 finished. Please press enter to continue.....");
            //note: I've used this here to pause the program to allow the user to see the output
            Console.ReadLine();
            Console.Clear();

            /*------- End of Task 3 -------*/





            /*---------- Task 4 -----------*/
            /*-------- Odd or Even --------*/

            //Title
            Console.WriteLine("****************************");
            Console.WriteLine("********** Task 4 **********");
            Console.WriteLine("****************************");

            Console.Write("Please enter a number i'll tell you if its odd or even: ");
            int input = int.Parse(Console.ReadLine());

            //Use the modulus operator to check if there is a remainder when the number is divided by 2
            if (input % 2 == 0)
                Console.WriteLine("The number you gave me was even.");
            else
                Console.WriteLine("The number you gave me was odd.");

            //Give the user a meaningfull output to let them know this part is complete.
            Console.WriteLine("Task 4 finished. Please press enter to continue.....");
            //note: I've used this here to pause the program to allow the user to see the output
            Console.ReadLine();
            Console.Clear();

            /*------- End of Task 4 -------*/





            /*---------- Task 5 -----------*/
            /*-------- Pin Number ---------*/

            //Title
            Console.WriteLine("****************************");
            Console.WriteLine("********** Task 5 **********");
            Console.WriteLine("****************************");

            //Ask for the users pin and save it in an int variable called pin.
            Console.Write("Please enter a 4 digit pin number: ");
            int pin1 = int.Parse(Console.ReadLine());

            //Using nested if statements to check if the pin is between the desired ranges then if the reentered pin matches.
            if (pin1 > 1000 && pin1 < 9999)
            {
                Console.Write("Please re-emter your pin: ");
                int pin2 = int.Parse(Console.ReadLine());
                //Nested if statement(if inside an if)
                if (pin1 == pin2)
                    Console.WriteLine("Pin Accepted.");
                else
                    Console.WriteLine("Your pins did not match.");
            }
            else
                Console.WriteLine("Your pin did not meet the requirements.");

            //Give the user a meaningfull output to let them know this part is complete.
            Console.WriteLine("Task 5 finished. Please press enter to continue.....");
            //note: I've used this here to pause the program to allow the user to see the output
            Console.ReadLine();
            Console.Clear();

            /*------- End of Task 5 -------*/





            /*---------- Task 6 -----------*/
            /*-------- Palindrome ---------*/

            //Title
            Console.WriteLine("****************************");
            Console.WriteLine("********** Task 6 **********");
            Console.WriteLine("****************************");

            //Ask the user for the 3 letter word leter ny letter
            Console.WriteLine("3 letter word Palindrome checker.");
            Console.Write("Please enter your first letter: ");
            string letter1 = Console.ReadLine();
            Console.Write("Please enter your second letter: ");
            string letter2 = Console.ReadLine();
            Console.Write("Please enter your third letter: ");
            string letter3 = Console.ReadLine();

            //Check if the first and last letters are the same
            if (letter1 == letter3)
            {
                //check if the middle letter is a vowel
                if (letter2 == "a" || letter2 == "e" || letter2 == "i" || letter2 == "o" || letter2 == "u")
                    //Using the placeholders to show the variables in the string output
                    Console.WriteLine("{0}{1}{2} is a palindrome", letter1, letter2, letter3);
                else
                    Console.WriteLine("I dont think that's a real word.");
            }
            else
                Console.WriteLine("{0}{1}{2} isn't a palindrome.",letter1, letter2, letter3);

            //Give the user a meaningfull output to let them know this part is complete.
            Console.WriteLine("Task 6 finished. Please press enter to continue.....");
            //note: I've used this here to pause the program to allow the user to see the output
            Console.ReadLine();
            Console.Clear();

            /*------- End of Task 6 -------*/

        }
    }
}
