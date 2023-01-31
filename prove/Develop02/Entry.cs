using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
     public string _date;
    public string _prompt = " ";
    public string _response = " ";

    public void Response()
    {
        
        Console.WriteLine("\nEnter your response: \n");
        _response = Console.ReadLine(); 

    }
    public void DisplayEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date = dateText;

        Console.WriteLine($"Date: {_date} | - Prompt: {_prompt} | Response: {_response}");
       
         
    }
}