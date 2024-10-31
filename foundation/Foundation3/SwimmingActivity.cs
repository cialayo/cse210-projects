public class SwimmingActivity : Activity
{
    private double _lapsNumber;
    public SwimmingActivity(string name, int lenght, double lapsNumber) : base(name, lenght)
    {
        _lapsNumber = lapsNumber;
    }
    public override double GetDistance()
    {
        double distance = _lapsNumber * 50 / 1000;
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = this.GetDistance() / _lenght * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = _lenght / this.GetDistance();
        return pace;
    }
}