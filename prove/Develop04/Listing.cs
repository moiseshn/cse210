using System;
public class Listing : Activity
{
    // Attributes
    private List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    private string _pickedPrompt;

    // Constructors
    public Listing() : base()
    {
        _activityName = "Listing";
        _activityDetails = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _activityDuration = GetActivityDuration();
    }

    // Methods
    public void GetListingSession()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(_spinnerDuration);
        GetRandomPrompt();
        GetAnswers();
    }
    private void GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int indexNumber = randomPrompt.Next(_prompts.Count);
        _pickedPrompt = _prompts[indexNumber];
        Console.WriteLine($"\nList as many responses you can to the following prompt:\n");
        Console.WriteLine($">>> {_pickedPrompt}\n");
        Console.Write("You may begin in: ");
        CountdownTimer(9);
        Console.WriteLine("");
    }
    private void GetAnswers()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            i++;
        }
        Console.Write($"\nYou listed {i} items. ");
        ShowSpinner(_spinnerDuration);
    }
}
