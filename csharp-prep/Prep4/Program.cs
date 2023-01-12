using System;

using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;
        
        while (number != 0)
        { 
            // Ask for number from user.
            Console.Write("Please enter a number (0 to exit): ");
            string userInput = Console.ReadLine();

            number = int.Parse(userInput);

            // Add number to the list if it is not zero
            if (number != 0)   
            {
                numbers.Add(number);
            }
        }

        // Part 1: Compute the sum.
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;   
        } 
        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Compute the average of the numbers in the list.
        float average = ((float) sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        // Part 3: Compute the largest number in the list.
        int largest = numbers[0];

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        Console.WriteLine($"The largest is: {largest}");
    
    }
}