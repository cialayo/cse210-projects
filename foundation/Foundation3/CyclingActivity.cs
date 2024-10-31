public class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(string name, int lenght, double speed) : base(name, lenght)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        double distance = (_speed * _lenght) / 60;
        return distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}