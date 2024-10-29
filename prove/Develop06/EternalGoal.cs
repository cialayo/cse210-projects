public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
    }
    public override void RecordEvent()
    {
    }
    public override bool IsComplete()
    {
        bool _isComplete = false;
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        string detailsString = $"[ ] {_shortName} ({_description})";
        return detailsString;
    }
    public override string GetStringRepresentation()
    {
        string stringRepresentation = $"EternalGoal,{_shortName},{_description},{_points}, false";
        return stringRepresentation;
    }

}
