using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    //Define the response randomizing method that returns a random prompt.
    public string Getprompt()
    {  
        string filename = "journal.txt";
        string[] lines = File.ReadAllLines(filename);
        Random rand  = new Random();
        int prompt = rand.Next(lines.Count());

        string randPrompt = lines[prompt];
         
        return randPrompt;
    }


}