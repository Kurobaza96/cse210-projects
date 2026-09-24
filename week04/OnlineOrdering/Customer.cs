public class Customer
{
    private string _name;
    private Address _address;

    // Constructor to initialize the customer with name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to get the customer's name, address, and whether they are in the USA
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}