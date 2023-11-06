using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 520143;
        int response = 0; // Initialize response

        while (response != number)
        {
            Console.WriteLine("Guess the Number! ");
            string userInput = Console.ReadLine();

            // Try to convert the user input into an integer
            bool isNumber = int.TryParse(userInput, out response);

            // If conversion was successful and the guess is not correct, give a hint
            if (isNumber)
            {
                if (response < number)
                {
                    Console.WriteLine("Too low, try again.");
                }
                else if (response > number)
                {
                    Console.WriteLine("Too high, try again.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }

        // If the loop ends, the user has guessed the number
        Console.WriteLine("Congratulations! You guessed the number!");
    }
}
