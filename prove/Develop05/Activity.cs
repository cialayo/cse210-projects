using System.ComponentModel;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _date;
    public Activity()
    {
        _name = "";
        _description = "";
        _date = 0;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.Write("");
        Console.Write("How long, in seconds, would you like for your session?");
        _date = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        this.ShowSpinner(5);
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        this.ShowSpinner(5);
        Console.WriteLine($"You have completed another {_date} seconds of the {_name}");
        this.ShowSpinner(5);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
