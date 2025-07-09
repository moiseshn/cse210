using System;
public class Swimming : Activity
{
    // Attributes
    private int _laps;

    // Constructor
    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    // Methods
    public override double GetDistance()
    {
        // Distance (miles) = swimming laps * 50 / 1000 * 0.62
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        return GetDistance() / _minutes * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }
}