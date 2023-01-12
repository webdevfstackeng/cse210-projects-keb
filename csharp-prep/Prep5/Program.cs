using System;

class Program
{
    static void Main(string[] args)
    {
        // Functions call.
        DisplayWelcomeMsg();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int numSquared = SquareNumber(userNumber);

        DisplayResult(userName, numSquared);
        
        // Welcome message display void function definition.
        static void DisplayWelcomeMsg()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // Fullname function defination.
        static string PromptUserName()
        {
            Console.Write("Please enter your fullname: ");
            string fullname = Console.ReadLine();

            return fullname;
        }

        // Favorite number function defination.
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());

            return favoriteNumber;          
        }

        // Number squared function defination.
        static int SquareNumber(int number)
        {
            int numberSquared = number * number;
            
            return numberSquared;
        }

        // Disply results void function defination.
        static void DisplayResult(string fullname, int numberSquared)
        {
            Console.WriteLine($"{fullname}, the square of your number is {numberSquared}");
        }
        
        
    }
}