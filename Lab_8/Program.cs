using System;

namespace Lab_8
{
    class Program
    {
        static int promptUserAndReadInteger()
        {
            // initiates while loop as long as input return is true
            while (true)
            {
                // try catch to validate user input is the correct format needed to run program
                try
                {
                    Console.WriteLine("Enter a number 1-19");
                    int num = int.Parse(Console.ReadLine());
                    if (num > 0 && num <= 19)
                    {
                        return num;
                    }
                    else
                        throw new IndexOutOfRangeException();
                }
                // throws format exception if user input is not a valid input
                catch (FormatException)
                {
                    Console.WriteLine("That student does not exist");
                }
                catch (IndexOutOfRangeException)
                {
                    //prompts user to try again to enter a valid input.
                    Console.WriteLine("That is invalid data. (enter a number 1-19)");

                }
            }
        }
        //begins main class of code to initialize program
        static void Main(string[] args)
        {
            Console.Write("Welcome to the best C# class ever " + (" "));

            // string arrays to input class data and align each item between arrays to match 1-19 user input
            string[] students = new string[] { "Andrea", "Tony", "Brian", "Camille", "Clayton", "Mace", "David", "Evan", "Heather", "Jacky", "Johnathan", "Katie", "Levi", "Mauricio", "Nicholas", "Rudy", "Sean'O", "Steve", "Ty" };
            string[] gender = new string[] { "female", "male", "male", "female", "male", "male", "male", "male", "female", "male", "male", "female", "male", "male", "male", "male", "male", "male", "male" };
            string[] color = new string[] { "green", "hunter green", "blue", "purple", "orange", "red", "indigo", "maroon", "yellow", "teal", "pink", "navy blue", "brown", "light green", "tan", "grey", "gold", "silver", "orange" };

            string doAgain;
            bool cont = true;
            while (cont)
            {
                //Stores the number that the user inputs and prompts user to pick a fact
                int userInput = promptUserAndReadInteger(); 
                string numericalStudent = students[userInput - 1];
                Console.WriteLine("Student " + userInput + " is " + numericalStudent);
                Console.Write("What would you like to know about " + numericalStudent + "?");
                Console.WriteLine((" ") + "(enter a gender or color.)");
                string choices = Console.ReadLine().ToLower();

                bool repeat = true;
                while (repeat)
                {
                    //if else statements to determine user input to display proper feedback of data
                    if (choices == "color")
                    {
                        Console.WriteLine(numericalStudent + (" ") + "favorite color is " + (" ") + color[userInput - 1]);
                        repeat = false;
                    }

                    else if (choices == "gender" || choices == "gender")
                    {
                        Console.WriteLine(numericalStudent + (" ") + "is a " + (" ") + gender[userInput - 1]);
                        repeat = false;
                    }
                    else
                    {
                        Console.Write("That data does not exist. Please try again.");
                        Console.WriteLine("(enter a gender or color)");
                        choices = Console.ReadLine();
                    }
                }
                bool cont2 = true;
                while (cont2)
                {
                    // while loop prompts user to continue running program
                    Console.WriteLine("Continue? (y/n)");
                    doAgain = Console.ReadLine().ToLower();

                    if (doAgain == "y"|| doAgain == "yes")
                    {
                        cont2 = false;
                    }
                    else if (doAgain == "n"|| doAgain == "no")
                    {
                        Console.WriteLine("Goodbye!");
                        cont2 = false;
                        cont = false;

                    }
                    else
                    {
                        //if user does not enter y or n, prompts user to try again
                        Console.WriteLine("Invalid input. Try again.");
                    }
                }
            }
        }
    }
}
