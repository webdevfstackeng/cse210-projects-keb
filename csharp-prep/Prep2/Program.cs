using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string percentageMark = Console.ReadLine();
        int score = int.Parse(percentageMark);

        string letter = " ";

        if (score >= 90)
        {
            letter  = "A";
        }

        else if (score >= 80)
        {
            letter  = "B";
        }

        else if (score >= 70)
        {
            letter  = "C";
        }

        else if (score >= 60)
        {
            letter  = "D";
        }

        else
        {
            letter  = "F";
        }
        Console.WriteLine($"Your grade is: {letter}.");

        if (score >= 70)
        {
        Console.WriteLine($"Congratulations!, you have passed.");
        }

        else
        {
            Console.WriteLine($"Good luck next time.");
        }

    }

    
}