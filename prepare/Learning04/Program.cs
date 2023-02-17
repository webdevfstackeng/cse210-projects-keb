using System;

class Program
{
    static void Main(string[] args)
    {   // Super class instantiation and assinments
        Assignment summary = new Assignment("Samuel James", "Addition");
        Console.WriteLine(summary.GetSummary());
        Console.WriteLine();

        // Sub class instantiation and assinments 
        MathAssignment homeworklist = new MathAssignment("Paul Simon", "Algebra", "8.6", "12-3");
        Console.WriteLine(homeworklist.GetSummary());
        Console.WriteLine(homeworklist.GetHomeworkList());
        Console.WriteLine();

        // Sub class instantiation and assinments 
        WritingAssignment writing = new WritingAssignment("Andrew Bowe", "African Philosophy", "The Causes of Natural Disasters");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
        Console.WriteLine();
    }
}