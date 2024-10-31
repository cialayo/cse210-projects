public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string name, int lenght, double distance) : base(name, lenght)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = (_distance / _lenght) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = _lenght / _distance;
        return pace;
    }
}