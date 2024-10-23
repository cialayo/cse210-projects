using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment example = new Assignment("Samuel Bennnet", "Multiplication");
        string summary = example.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine("");
        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string info = math.GetHomeworkList();
        Console.WriteLine(info);
        Console.WriteLine("");
        WritingAssignment write = new WritingAssignment("Mary Waters", "European History", "The Cuases of Worl War II");
        string writingInformation = write.GetWritingInformation();
        Console.WriteLine(writingInformation);

    }
}