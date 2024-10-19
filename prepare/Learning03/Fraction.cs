public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop()
    {
        Console.WriteLine(_top);
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";

        return fraction;
    }

    public double GetDecimalValue()
    {
        int top = _top;
        double convertedTop = Convert.ToDouble(top);
        int bottom = _bottom;
        double convertedBottom = Convert.ToDouble(bottom);
        double decimalValue = convertedTop / convertedBottom;
        return decimalValue;
    }
}