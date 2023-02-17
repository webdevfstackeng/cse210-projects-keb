using System;

// Math Assignment Sub class
public class MathAssignment : Assignment  
{
    private string _textbookSection;
    private string _problems;

    // Consrtructor setter
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetTextbookSection()  // Textbook section getter
    {
        return _textbookSection;
    }

    public string GetProblems()    // Problems getter
    {
        return _problems;
    }

    public string GetHomeworkList()     // Homework getter
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

     

    
}