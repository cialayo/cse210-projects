public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
        _date = 0;
        _count = 0;
        _prompts = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    }
    public void Run()
    {
        this.DisplayStartingMessage();
        Console.WriteLine("List as many reponses you can to the following prompt:\n");
        this.GetRandomPrompt();
        Console.Write("You may begin in: ");
        this.ShowCountDown(5);
        Console.WriteLine("");
        this.GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
    }
    private void GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(0, _prompts.Count - 1);
        string randomPrompt = _prompts[i];
        Console.WriteLine(randomPrompt);
    }
    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_date);

        List<string> listFromUser = [""];

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string prompt = Console.ReadLine();
            _prompts.Add(prompt);
            _count++;
        }
        return listFromUser;
    }

}
