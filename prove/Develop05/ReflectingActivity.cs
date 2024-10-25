public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n";
        _prompts = new List<string>(){
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};
        _questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};
        _date = 0;
    }
    public void Run()
    {
        this.DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:\n");
        this.DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.Write("You may begin in: ");
        this.ShowCountDown(5);
        Console.Clear();

        for (int i = (_date / 10); i > 0; i--)
        {
            this.DisplayQuestion();
            this.ShowSpinner(_date / 2);
            Console.WriteLine();
        }
        this.DisplayEndingMessage();


    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(0, _prompts.Count - 1);
        string randomPrompt = _prompts[i];
        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int j = random.Next(0, _questions.Count - 1);
        string randomQuestion = _questions[j];
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }
    public void DisplayQuestion()
    {
        Console.Write($">{GetRandomQuestion()} ");

    }

}