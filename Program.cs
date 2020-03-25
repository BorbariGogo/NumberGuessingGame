using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function 

            GreetUsers();  // Run GreetUsers function

            while (true)

            {

                // Init correct number
                //int correctNumber = 8;

                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask users for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is incorrect
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorAndMessage(ConsoleColor.Red, "Please use actual number");

                        // Keep going
                        continue;

                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorAndMessage(ConsoleColor.Red, "Wrong number, please try again");

                    }
                }

                // Print success message
                PrintColorAndMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }


            void GetAppInfo()
            {
                // app var
                string appName = "Number Guesser";
                string appVersion = "1.0.0";
                string appAuthor = "Borbari Gogo-Abbey";

                // Change text color
                Console.ForegroundColor = ConsoleColor.Green;

                // app info
                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

                // Reset color
                Console.ResetColor();

            }


            // Ask users name and greet
            void GreetUsers()
            {
                // Ask users name
                Console.WriteLine("What is your name?");

                // Get user input
                string inputName = Console.ReadLine();

                Console.WriteLine("Hello {0}, let's play a game.....", inputName);
            }

            // Print color and message
            void PrintColorAndMessage(ConsoleColor color, string message)
            {
                // Change text color
                Console.ForegroundColor = color;

                // Tell user it's not a number
                Console.WriteLine(message);

                Console.ResetColor();
            }
        }

    }
}

