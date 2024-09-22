using System;

class Program
{
    static void Main(string[] args)
    {
        // program that determines the letter grade for a course
        Console.Write("What is your grade percentage?");
        string valueInText = Console.ReadLine();
        int gradeInPercentage = int.Parse(valueInText);

        if (gradeInPercentage >= 90)
        {
            Console.Write("You've got an A");
        }
        else if (gradeInPercentage < 90 && gradeInPercentage >= 80)
        {
            Console.Write("You've got a B");
        }
        else if (gradeInPercentage < 80 && gradeInPercentage >= 70)
        {
            Console.Write("You've got a C");
        }
        else if (gradeInPercentage < 70 && gradeInPercentage >= 60)
        {
            Console.Write("You've got a D");
        }
        else
        {
            Console.Write("You've got an F");

        }
    }
}