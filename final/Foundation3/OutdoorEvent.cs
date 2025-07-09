using System;
public class OutdoorEvent : Event
{
    // Attributes
    private string _weatherForecast;

    // Constructors
    public OutdoorEvent(string title, string description, string date, string time, string weatherForecast) : base(title, description, date, time)
    {
        _weatherForecast = weatherForecast;
    }

    // Methods
    public override string DisplayShortText()
    {
        // type of event, title, and the date
        return $"\nEvent Type: {GetType().Name}\nTitle: {_title}\nDate: {_date}";
    }
    public override string DisplayStandardText()
    {
        // title, description, date, time, and address
        return $"\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.DisplayAddress()}";
    }

    public override string DisplayFullText()
    {
        // event type, title, description, date, time, and address + specificvattributes
        return $"\nEvent Type: {GetType().Name}\nWeather Forecast: {_weatherForecast}\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.DisplayAddress()}";
    }
}