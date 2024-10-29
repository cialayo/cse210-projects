using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal sgoal = new SimpleGoal("tgoal", "test goal", "10", true);
        Console.WriteLine(sgoal.GetStringRepresentation());
        Console.WriteLine(sgoal.GetDetailsString());
    }
}