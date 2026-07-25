public class Customer
{
    private string _name;
    private Address _address;

    public bool LivesInUSA()
    {
        return _address.InsideUSA();
    }

    public Customer(string name, Address address)
    {
     _name = name;
     _address = address;
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetFormattedAddress()
    {
        return _address.GetAddress();
    }
}