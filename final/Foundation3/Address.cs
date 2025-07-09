using System;
public class Address
{
    // Attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructors
    public Address()
    { }

    // Methods
    public string DisplayAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }

    // Setters --- used in Event SetEventAddress()
    public void SetStreet(string street)
    {
        _street = street;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
}