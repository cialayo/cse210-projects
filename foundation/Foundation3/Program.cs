using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new RunningActivity("Running", 30, 4.8));
        activities.Add(new RunningActivity("Running", 40, 5.8));
        activities.Add(new CyclingActivity("Cycling", 20, 8));
        activities.Add(new CyclingActivity("Cycling", 10, 9));
        activities.Add(new SwimmingActivity("Swimming", 30, 20));
        activities.Add(new SwimmingActivity("Swimming", 50, 30));
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine("");
        }
    }
}