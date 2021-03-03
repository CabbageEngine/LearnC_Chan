using System;

namespace LearnC_Book
{
    class Program
    {

        // Learn C# Well - Book Exercises
        static void Main(string[] args)
        {

            // Set string and integer variables to store user input

            string userName = "";
            int userAge = 0;
            int currentYear = 0;

            // Enter name
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            // Enter age
            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());


            // Conditional statement to determine valid age
            if (userAge < 0 || userAge > 100)
            {
                Console.WriteLine("Invalid Age");
                Console.WriteLine("Age must be between 0 and 100.\n");
            }
            else if (userAge < 18)
                Console.WriteLine("Sorry, you are underage.\n");
            else if (userAge < 21)
                Console.WriteLine("You need parental consent.\n");
            else
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("You may sign up for the event!\n");
            }
            Console.WriteLine();


            // Enter current year
            Console.Write("Please enter the current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());

            // Print data entries and output result
            Console.WriteLine("Hello, my name is {0} and I am {1} years old. I was born in {2}.\n", userName, userAge, currentYear - userAge);

            // Inline If Statement checks condition - if true return value : if false return value
            int myNum = 3 > 2 ? 10 : 5;
            Console.WriteLine(myNum); // Since the statement is true - it will return the number 10


            // Switch Statement that takes input in a certain format and outputs a result
            Console.WriteLine();
            Console.WriteLine("Enter your grade: ");
            string userGrade = Console.ReadLine().ToUpper();

            switch (userGrade)
            {
                case "A+":
                case "A":
                    Console.WriteLine("Distinction");
                    break;
                case "B":
                    Console.WriteLine("B Grade");
                    break;
                case "C":
                    Console.WriteLine("C Grade");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;
            }

            // For loop that prints a series of numbers in an array based on how many variables are stored
            Console.WriteLine();
            int[] myNumbers = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }

            // Displaying single characters in an array using a foreach loop
            Console.WriteLine();
            char[] message = { 'H', 'e', '1', '1', 'o', };

            foreach (char i in message)
                Console.Write(i);


            // While Loop
            Console.WriteLine("\n");
            int counter = 5;

            while (counter > 0)
            {
                Console.WriteLine("Counter = {0}", counter);
                counter = counter - 1;
            }

            // Do While Loop. Executes the code inside curly braces at least once
            Console.WriteLine();
            int counter2 = 100;

            do
            {
                Console.WriteLine("Counter = {0}", counter2);
                counter2++;

            } while (counter2 < 0);


            // Using Jump Statement - Break and Continue
            Console.WriteLine("\n");
            int ii = 0;

            for (ii = 0; ii < 5; ii++)
            {
                Console.WriteLine("ii = {0}", ii);
                if (ii == 2) // Loop ends when the number 2 is reached
                    break;
            }

            for (int aye = 0; aye < 5; aye++)
            {
                Console.WriteLine("i = {0}", aye);
                if (aye == 2)
                    continue;
                Console.WriteLine("I will not be printed if i = 2.\n");
            }

            // Exception Handling - Using a Try / Catch block
            Console.WriteLine("\n");
            double numerator, denominator;

            Console.Write("Please enter the numerator: ");
            numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the denominator: ");
            denominator = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("The result is {0}.", numerator / denominator);
            }
            catch (Exception e) // The Exception Class handles all general errors and has a property called Message
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("---- End of Error Handling Example ----");
            }

            // Specific Errors for Exception Handling in a Try / Catch block
            Console.WriteLine("\n");
            int choice = 0;

            int[] numbers = { 10, 11, 12, 13, 14, 15 };
            Console.WriteLine("Please enter the index of the array: ");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("numbers[{0}] = {1}", choice, numbers[choice]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Index should be from 0 to 5.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: You did not enter an integer.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
    }
}
