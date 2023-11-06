using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0) break;
            numbers.Add(number);
        }

        int sum = 0;
        int max = (numbers.Count > 0) ? numbers[0] : 0;

        foreach (int num in numbers)
        {
            sum += num;
            if (num > max) max = num;
        }

        double average = (numbers.Count > 0) ? (double)sum / numbers.Count : 0;

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);
    }
}
