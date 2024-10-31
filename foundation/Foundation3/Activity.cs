public abstract class Activity
{
    private string _name;
    private DateTime _date;
    protected int _lenght;
    public Activity(string name, int lenght)
    {
        _name = name;
        _date = DateTime.Now;
        _lenght = lenght;
    }
    public string GetName()
    {
        return _name;
    }

    public string GetDate()
    {
        string date = _date.ToString("dd MMMM yyyy");
        return date;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public void GetSummary()
    {
        Console.WriteLine($"{GetDate()} {GetName()} ({_lenght} min): Distance {GetDistance():F2} km, Speed:{GetSpeed():F2} kph, Pace:{GetPace():F2} min per km");
    }

}