using System.ComponentModel;

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
        int optionChosen = 0;
        while (optionChosen != 6)
        {
            DisplayPlayerInfo();
            Menu();
            Console.Write($"Select a choice from the menu: ");
            optionChosen = int.Parse(Console.ReadLine());

            if (optionChosen == 1)
            {
                CreateGoal();
            }
            else if (optionChosen == 2)
            {
                ListGoalDetails();
            }
            else if (optionChosen == 3)
            {
                SaveGoals();
            }
            else if (optionChosen == 4)
            {
                LoadGoals();
            }
            else if (optionChosen == 5)
            {
                ListGoalNames();
                RecordEvent();
            }
            else
            {
                break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortname()} ");
        }

    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()} ");
        }
        Console.WriteLine("");
    }
    public void CreateGoal()
    {
        MenuGoals();
        Console.Write($"Which type of goal would you like to create? ");
        int goalChosen = int.Parse(Console.ReadLine());
        Console.Write($"What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write($"What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write($"What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());

        if (goalChosen == 1)
        {
            _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints, false));
        }
        else if (goalChosen == 2)
        {
            _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        else
        {
            Console.Write($"How many times does this goal need to be accomplished for a bonus? ");
            int goalTarget = int.Parse(Console.ReadLine());
            Console.Write($"What is the bonus for completing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());
            int goalAmountCompleted = 0;
            _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalAmountCompleted, goalTarget, goalBonus));
        }
        Console.WriteLine("");
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int i = int.Parse(Console.ReadLine()) - 1;
        _goals[i].RecordEvent();
        _score += _goals[i].GetPoints();
        Console.WriteLine($"Congratulations! You have earned: {_goals[i].GetPoints()}");
    }
    public void SaveGoals()
    {
        Console.WriteLine("");
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();
        using (StreamWriter savedFile = new StreamWriter(file, false))
        {
            savedFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                savedFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("");
    }
    public void LoadGoals()
    {
        Console.WriteLine("");
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] text = lines[i].Split(':');
            string goalChosen = text[0];
            string[] parts = text[1].Split(',');
            string goalName = parts[0];
            string goalDescription = parts[1];
            int goalPoints = int.Parse(parts[2]);

            if (goalChosen == "SimpleGoal")
            {
                bool goalComplete = bool.Parse(parts[3]);
                _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints, goalComplete));
            }
            else if (goalChosen == "EternalGoal")
            {
                _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
            }
            else if (goalChosen == "ChecklistGoal")
            {
                int goalAmountCompleted = int.Parse(parts[4]);
                int goalTarget = int.Parse(parts[5]);
                int goalBonus = int.Parse(parts[6]);
                _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalAmountCompleted, goalTarget, goalBonus));
            }
        }
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
    public static void MenuGoals()
    {
        Console.WriteLine("The types of goals are");
        Console.WriteLine("  1.Simple Goal");
        Console.WriteLine("  2.Eternal Goal");
        Console.WriteLine("  3.Checklist Goal");
    }
}