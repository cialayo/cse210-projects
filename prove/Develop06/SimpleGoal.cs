public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points, bool isComplete) : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        string detailsString = "";
        if (_isComplete == true)
        {
            detailsString = $"[X] {_shortName} ({_description})";
        }
        else
        {
            detailsString = $"[ ] {_shortName} ({_description})";
        }

        return detailsString;
    }
    public override string GetStringRepresentation()
    {
        string stringRepresentation = $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";


        return stringRepresentation;
    }


}