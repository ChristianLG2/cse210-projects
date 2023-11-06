using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName(); // Ensure that the result of PromptUserName() is stored
        int userNumber = PromptUserNumber(); // This should be an int, not a string

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber); // Pass squaredNumber instead of userNumber
    }
    
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!"); // Ensure that semicolons are used at the end of each statement
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your username: "); // Correct the prompt message
        string name = Console.ReadLine(); // Correctly read the input into a variable

        return name; // Return the read name
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your number: "); // Correct the prompt message
        string input = Console.ReadLine(); // Read the input as a string
        int number;
        
        // Attempt to parse the input as an integer. If it fails, prompt again.
        while (!int.TryParse(input, out number))
        {
            Console.WriteLine("Invalid number, please enter a valid integer.");
            input = Console.ReadLine();
        }
        
        return number; // Return the parsed number
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        // Correct the variable name in the interpolated string from 'squre' to 'square'
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}

