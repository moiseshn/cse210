using System;
public class Breathing : Activity
{
    // Attributes
    private int _breatheInSecs = 4;
    private int _breatheHoldSecs = 6;
    private int _breatheOutSecs = 8;
    private int _spinnerDuration = 5;
    // Constructors
    public Breathing() : base()
    {
        _activityName = "Breathing";
        _activityDetails = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _activityDuration = GetActivityDuration();
    }

    // Methods
    public void GetBreathingSession()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(_spinnerDuration);
        GetBreathingCountdown();
    }
    private void GetBreathingCountdown()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\nBreathe in... ");
            CountdownTimer(_breatheInSecs);
            Console.Write("\nHold it... ");
            CountdownTimer(_breatheHoldSecs);
            Console.Write("\nBreathe out... ");
            CountdownTimer(_breatheOutSecs);
            Console.WriteLine("");
        }
    }
}
