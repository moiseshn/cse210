using System;
public abstract class Activity
{
    // Attributes
    protected string _date;
    protected int _minutes;
    // Constructor
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    // Methods
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}