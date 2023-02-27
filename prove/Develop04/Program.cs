using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            //Console.Clear();
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Welcome to the Breathing Activity.");
                    Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly." + "Clear your mind and focus on breathing.");
                    Console.WriteLine();
                    //Console.WriteLine($"{_description}");
                    Console.WriteLine();

                    BreathingActivity breathing = new BreathingActivity();
                    breathing.DisplayStartMessage();
                    breathing.RunActivity();
                    breathing.DisplayEndMessage();
                     
                    break;
                case 2:
                    Console.WriteLine("Welcome to the Reflecting Activity.");
                    // Code to perform Activity 
                    break;
                case 3:
                    Console.WriteLine("Welcome to the Listing Activity.");
                    // Code to perform Activity 
                    break;
                case 4:
                    Console.WriteLine("We hope the Mindfulness Activity was time well spent. Thank you!!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 4);
    }
}