using System;
using System.Collections.Generic;

public class Resume
{
    // Member variable for string name.
    public string _name = " ";
    
    public List<Job> _jobs = new List<Job>(); 

    // Method to display the name and all the jobs.
    public void DisplayResumeDetails()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Jobs:");
             
            for (int i = 0; i < _jobs.Count; i++)
            { 
                Console.WriteLine($"{_jobs[i]._jobTitle}");
            }
        }




    
}
