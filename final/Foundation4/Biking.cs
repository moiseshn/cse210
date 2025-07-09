using System;
public class Biking : Activity
{
    // Attributes
    private double _speed;

    // Constructor
    public Biking(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }
    // Methods
    public override double GetDistance()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        // Distance = Speed * minutes / 60
        return _speed * _minutes / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        // Pace = 60 / speed
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }
}