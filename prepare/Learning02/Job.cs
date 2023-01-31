using System;
 
public class Job
{
    // member attributes.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Method for displaying job information.
    public void DisplayJobInformation()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}

 
    