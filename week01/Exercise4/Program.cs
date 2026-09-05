using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Please Enter a list of numbers, type 0 when finished.");

        // Keep prompting the user for numbers until they enter 0
        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        // Sums up the numbers in the list
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        // 2. Calculates the average
        double average = (double)sum / numbers.Count;

        // 3. Find the largest number
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        // Print the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}