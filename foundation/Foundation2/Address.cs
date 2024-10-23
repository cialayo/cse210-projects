public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool InUSA()
    {
        bool inUSA = false;
        if (_country == "USA")
        {
            inUSA = true;
        }

        return inUSA;
    }
    public string GetAddress()
    {
        string completeAddress = $"{_streetAddress}\n{_city}, {_state}\n{_country}";
        return completeAddress;
    }
}