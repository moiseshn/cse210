using System;
public class Running : Activity
{
    // Attributes
    private double _distance;

    // Constructor
    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    // Methods
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        return _distance / _minutes * 60; // Miles per Hour
    }
    public override double GetPace()
    {
        // Pace = 60 / speed
        return 60 / GetSpeed(); // Minutes per Mile
    }
    public override string GetSummary()
    {
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{_date} {GetType().Name} ({_minutes} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }
}