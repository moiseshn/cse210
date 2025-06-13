using System;
public class Activity
{
    // Attributes
    protected string _activityName;
    protected string _activityDetails;
    protected int _activityDuration;
    protected int _spinnerDuration = 5;

    // Constructors
    public Activity()
    {

    }

    // Methods
    public int GetActivityDuration()
    {
        return _activityDuration;
    }
    public void GetStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.\n");
        Console.WriteLine($"{_activityDetails}\n");
        Console.Write($"How long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.CursorVisible = true;
    }
    public void GetEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!!");
        ShowSpinner(_spinnerDuration);
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName} Activity.");
        ShowSpinner(_spinnerDuration);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinner =
        [
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
        ];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
            Console.CursorVisible = false;
        }
    }
    public void CountdownTimer(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.CursorVisible = false;
        }
    }
}
