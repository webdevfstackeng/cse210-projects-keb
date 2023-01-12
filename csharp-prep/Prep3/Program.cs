using System;

class Program
{
    static void Main(string[] args)
    {
        // Used in Parts 1 and 2.
        // Console.Write("What is the magic number? ");
        // int randomNumber = int.Parse(Console.ReadLine()); 
        
        // Part 3 
        Random randomNumbersGenerator = new Random();
        int randomNumber = randomNumbersGenerator.Next(1,101);
        
        int guessNumber = 0;

        while (guessNumber != randomNumber)
        {
            Console.Write("What is your guess number? ");
            guessNumber = int.Parse(Console.ReadLine()); 
            
            if (guessNumber < randomNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guessNumber > randomNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
       
        

    }
}