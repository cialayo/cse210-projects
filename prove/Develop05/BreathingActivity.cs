public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _date = 0;
    }
    public void Run()
    {
        this.DisplayStartingMessage();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write($"Breathe in...");
        this.ShowCountDown(3);
        Console.WriteLine("");
        Console.Write($"Breathe out...");
        this.ShowCountDown(3);
        Console.WriteLine("");
        Console.WriteLine("");

        for (int i = (_date / 10); i > 0; i--)
        {
            Console.Write($"Breathe in...");
            this.ShowCountDown(4);
            Console.WriteLine("");
            Console.Write($"Breathe out...");
            this.ShowCountDown(6);
            Console.WriteLine("");
            Console.WriteLine("");
        }
        this.DisplayEndingMessage();
    }

}