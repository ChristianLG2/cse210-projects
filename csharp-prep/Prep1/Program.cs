using System;

class Program
{
    static void Main(string[] args)

    {
        // Ask the user for his name

        Console.WriteLine("What is your first Name? ");
        string first = Console.ReadLine();
        
        Console.WriteLine("What is your Last Name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is.. {last}, {first} {last}");

    }
}