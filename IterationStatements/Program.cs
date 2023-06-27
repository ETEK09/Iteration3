using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void NegativeOneThousand()
        {
            int index = 1000;
            while (index >= -1000)
            {
                Console.WriteLine(index);
                index--;
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void ByThree()
        {

            for (int i = 3; i < 999; i += 3)
            {
                Console.WriteLine(i);

            }

        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not


        static void EqualOrNot(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }


        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {

                Console.WriteLine("Odd");
            }
        }


        //Write a method to check whether a given number is positive or negative

        public static void PositiveorNegative(int number)
        {

            if (number < 0)
            {

                Console.WriteLine("Positive");

            }

            else {
                Console.WriteLine("Negative");


            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void VotingCandiate() 
        {
            Console.WriteLine("Please enter your age to see if your elible to vote: ");

            bool validnumber = int.TryParse(Console.ReadLine(), out int age);

            if (validnumber == true)
            {
                if (age >= 18)
                {
                    Console.WriteLine($"Congratulations. You are able to be vote");
                }
            else
                {
                    Console.WriteLine($"Not yet. But you will be able to vote in no time.");
                }

            }
            else
            {
                Console.WriteLine("Invalid number. Try again.");
            }
           
                
        }


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void Range() 
        {
            Console.WriteLine("Enter a number and we'll check to see if it's range. ");
            int number = int.Parse(Console.ReadLine());
            
            if (number <= 10 && number >= -10) 
            {
                Console.WriteLine("This number is in range");
            }

            else
            {
                Console.WriteLine("Not in range");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void Multiplication(int num) 
        {
            for (int i = 1; i <= 12; i++) 
            { 
                Console.WriteLine($"{i} x {num} = {i*num}");
            }
        
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //NegativeOneThousand();

            //ByThree();

            //EqualOrNot(1, 2);

            //EvenOrOdd(34);

            //PositiveorNegative(2);

            //VotingCandiate();

            //Range();

            Multiplication(12);

        } 
    } 
}











       
