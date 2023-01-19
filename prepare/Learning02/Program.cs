using System;

class Program
{
    static void Main(string[] args)
    {
        // Job class job1 instantiation.
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Hardware Engineer";
        job1._startYear = 2022;
        job1._endYear = 2030;

        // Job class job2 instantiation.
        Job job2 = new Job();
        job2._company = "Amazone";
        job2._jobTitle = "Web Developer";
        job2._startYear = 2021;
        job2._endYear = 2028; 
        
        // Resume class instantiation.
        Resume resume = new Resume();
        resume._name = "Kgotla Boabilwe";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResumeDetails(); 
        
    }
} 