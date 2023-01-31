using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    //Declare entry list
    public List<Entry> _entries = new List<Entry>();

    //Instantiate the Entry class 
    Entry entry = new Entry();
     
    // Define the load method
    public void LoadToFile()
    {
        Console.Write("Please enter a text file name (e.g mylournal.txt) and press enter: ");
        
        string userFileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(userFileName);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            _entries.Add(entry);
        }
        Console.WriteLine($"Entries loaded in file" + userFileName);

        
    }

    //Define the SaveEntry method.
    public void SaveEntry()
    {
        Console.WriteLine("Enter a text file name (e.g thoughts.txt) and press enter:");
        string userFileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
            
            Console.WriteLine("Happy Journaling!!. Text saved to file: " + userFileName);
        }
    }
}
 