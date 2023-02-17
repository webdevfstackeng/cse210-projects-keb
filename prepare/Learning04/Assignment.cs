using System;

// Supper class
public class Assignment
{
     protected string _studentName = "";
    private string _topic = "";
    public Assignment(string studentname, string topic)  //Setter constructor 
    {
        _studentName = studentname;
        _topic = topic;
    }

    public string GetStudentName()  //Student name getter
    {
        return _studentName;
    }

    public string GetTopic()    //Topic getter
    {
        return _topic;
    }
    public string GetSummary()  // Summary getter method
    {
        return _studentName + " - " + _topic;  
    } 
}




