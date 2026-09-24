public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor to initialize the address
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    // Method to get the address as a formatted string
    public string GetAddressString()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}