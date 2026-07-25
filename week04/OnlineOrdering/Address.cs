public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public bool InsideUSA()
    {
        return _country.ToUpper() == "USA" || _country.ToUpper() =="UNITED STATES";
    }

    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
}