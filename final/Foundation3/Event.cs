using System;
public abstract class Event
{
    // Attributes
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address = new Address();

    // Constructors
    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }
    // Setters
    public void SetEventAddress(string street, string city, string state, string country)
    {
        _address.SetStreet(street);
        _address.SetCity(city);
        _address.SetState(state);
        _address.SetCountry(country);
    }
    // Methods
    public abstract string DisplayShortText();
    public abstract string DisplayStandardText();
    public abstract string DisplayFullText();
}