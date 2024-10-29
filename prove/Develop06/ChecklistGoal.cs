using System.Runtime.InteropServices;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string shortName, string description, string points, int amountCompleted, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public int GetTotalPoints()
    {
        int totalPoints = 0;
        if (_amountCompleted == _target)
        {
            totalPoints = int.Parse(_points) + _bonus;
        }
        else
        {
            totalPoints = int.Parse(_points);
        }
        return totalPoints;
    }
    public override bool IsComplete()
    {
        bool _isComplete = false;
        return _isComplete;
    }
    public override string GetDetailsString()
    {

        string detailsString = "";
        // $"[ ] {_shortName} ({_description})";
        if (_amountCompleted == _target)
        {
            detailsString = $"[ ] {_shortName} ({_description}) -- Currently completed:{_amountCompleted}/{_target}";
        }
        else
        {
            detailsString = $"[X] {_shortName} ({_description}) -- Currently completed:{_amountCompleted}/{_target}";
        }
        return detailsString;
    }
    public override string GetStringRepresentation()
    {
        string stringRepresentation = $"ChecklistGoal,{_shortName},{_description},{_points},{IsComplete()},{_amountCompleted},{_bonus}; ";
        return stringRepresentation;
    }

}
