using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate both the Journal, Entry and PromptGenerator classes
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        Entry entry = new Entry();


        // A while loop for defining the options for calling the methods to process the journal entries.
        int choice = 0;

        while(choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the journal Program!");
            Console.WriteLine();

            Console.WriteLine("Please select one of the following choices (1 - 5):"); 
            Console.WriteLine();

            Console.WriteLine("1. Write (type new journal entry)");     
            Console.WriteLine("2. Display (view journal entry)");
            Console.WriteLine("3. Load (update recent text entries)");
            Console.WriteLine("4. Save (save text file) ");
            Console.WriteLine("5. Quit (exit program)");
            Console.WriteLine();

            Console.Write("What would you like to do? ");   // I added two more promts to the journal list file.

            choice = int.Parse(Console.ReadLine());

            string prompting = prompt.Getprompt();

            if (choice == 1)   
            {
                
                Console.WriteLine(prompting);   // I created a GetPrompt() method that generates a random prompt 
                entry._prompt = prompting;      // from journal list without a need for a loop. 
                entry.Response();               // A Response() function prompts the user to respond to a random prompt             
                        
            }
            else if (choice == 2)
            {
                entry.DisplayEntry();      
            }
            else if (choice == 3)
            {
                journal.LoadToFile();                       
            }
            else if (choice == 4)
            {
                journal.SaveEntry();                        
            }
                 
        }
    }
}