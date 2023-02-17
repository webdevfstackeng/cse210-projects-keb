using System;

// Writing Assignment Sub class
public class WritingAssignment : Assignment
{
    private string _title;

// Consrtructor setter
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public new string GetStudentName()      // Student name getter
    {
        return _studentName;
    }

    public string GetWritingInformation()       // Title and student name getter
    {
        return $"{_title} by {_studentName}";
    }
}
