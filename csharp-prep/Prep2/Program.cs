using System;

class Program
{
    static void Main(string[] args)
    {
        // program that determines the letter grade for a course
        Console.Write("What is your grade percentage?");
        string valueInText = Console.ReadLine();
        int gradeInPercentage = int.Parse(valueInText);

        string letter = ""; 

        if (gradeInPercentage >= 90)
        {
            letter = "A";
        }
        else if (gradeInPercentage < 90 && gradeInPercentage >= 80)
        {
            letter = "B";
        }
        else if (gradeInPercentage < 80 && gradeInPercentage >= 70)
        {
            letter = "C";
        }
        else if (gradeInPercentage < 70 && gradeInPercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";

        }

        if (letter == "A" || letter == "F")
        {
            Console.WriteLine($"You've got an {letter}");
        }
        else
        {
            Console.WriteLine($"You've got a {letter}");
        }

        if (gradeInPercentage >= 70)
        {
            Console.WriteLine("Congratulations you have passed the course!!!");
        }
        else
        {
            Console.WriteLine("You'll do it better next time");

        }
    }
}