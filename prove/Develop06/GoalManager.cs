public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {

    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalName()
    {
    }
    public void ListGoalDetails()
    {
    }
    public void CreateGoal()
    {

    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadDetails()
    {

    }
    public static void Menu()
    {
        Console.WriteLine("Menu Options");
        Console.WriteLine("  1.Create New Goal");
        Console.WriteLine("  2.List Goals");
        Console.WriteLine("  3.Save Goals");
        Console.WriteLine("  4.Load Goals");
        Console.WriteLine("  5.Record Event");
        Console.WriteLine("  6.Quit");
    }


}