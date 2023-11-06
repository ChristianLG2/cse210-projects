using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your grade percentage:");
        string input = Console.ReadLine();
        int grade = Int32.Parse(input);
        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign
        if (letter != "F" && letter != "A") // Exclude A and F from getting + or -
        {
            int lastDigit = grade % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && grade % 10 < 3)
        {
            // A- logic
            sign = "-";
        }
        // No additional logic is needed for F, as it does not get a sign

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. Better luck next time!");
        }
    }
}


