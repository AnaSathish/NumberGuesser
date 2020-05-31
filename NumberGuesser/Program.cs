using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            displayAppInfo();
            greetUser();

            while (true)
            {
                // init random number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        printColorMessage(ConsoleColor.Red, "Please enter a valid number.");
                        continue;
                    }
                    guess = Int32.Parse(input);
                    // incorrect guess
                    if (guess != correctNumber)
                    {
                        printColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }
                // output success message
                printColorMessage(ConsoleColor.Green, "You've guessed it!");

                Console.WriteLine("Play again? (Y/N)");
                string answer = Console.ReadLine().ToUpper();
                // only keep playing if Y
                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    return;
                }

            }
        }

        // displays app information
        static void displayAppInfo()
        {
            // set app vars
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Nandhana Sathish";
            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            // Write out the app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            // reset text color back to default white
            Console.ResetColor();
        }

        // asks for user's name and greets
        static void greetUser()
        {
            // ask user's name
            Console.WriteLine("What is your name?");
            // get user input
            string nameInput = Console.ReadLine();
            Console.WriteLine("Hello, {0}! Let's play NumberGuesser!", nameInput);
        }

        // prints the message in the given color
        static void printColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}