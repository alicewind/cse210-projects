using System;

public class Customer
{
    private string _name;
    private Address _address;

    string addressText = "";

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetDisplayText()
    {
        return $"{_name}\n{_address.GetDisplayText()}";
    }
    public bool LivesInUSA()
    {
        return _address.InUSA();
    }

}