using System;
public class Customer
{
    // Attributes
    private string _customerName;
    private Address _customerAddress = new Address();

    // Constructors
    public Customer()
    {}
   
    // Getter
    public string GetCustomerName()
    {
        return _customerName;
    }
    public string GetCustomerAddress()
    {
        return _customerAddress.DisplayAddress().ToString();
    }
    // Setters
    public void SetCustomerName(string name) // used in Order constructor 
    {
        _customerName = name;
    }
    public void SetCustomerAddress(string street, string city, string state, string country) // used in Order constructor
    {
        _customerAddress.SetStreet(street);
        _customerAddress.SetCity(city);
        _customerAddress.SetState(state);
        _customerAddress.SetCountry(country);
    }

    // Methods
    public bool IsUsaCustomer()
    {
        if (_customerAddress.IsUsa() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}