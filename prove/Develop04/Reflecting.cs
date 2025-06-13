using System;
public class Reflecting : Activity
{
    // Attributes
    private List<string> _prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];
    private string _pickedPrompt;
    private List<string> _reflectingQuestions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];

    // Constructors
    public Reflecting() : base()
    {
        _activityName = "Reflecting";
        _activityDetails = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _activityDuration = GetActivityDuration();
    }

    // Methods
    public void GetReflectingSession()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(_spinnerDuration);
        GetRandomPrompt();
        GetRandomQuestion();
    }
    private void GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int indexNumber = randomPrompt.Next(_prompts.Count);
        _pickedPrompt = _prompts[indexNumber];
        Console.WriteLine($"\nConsider the following prompt:\n");
        Console.WriteLine($">>> {_pickedPrompt}\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    private void GetRandomQuestion()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        CountdownTimer(8);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime)
        {
            Random randomQuestion = new Random();
            int indexNumber = randomQuestion.Next(_reflectingQuestions.Count);
            string pickedQuestion = _reflectingQuestions[indexNumber];
            Console.Write($">>> {pickedQuestion}\n");
            ShowSpinner(8);
        }
    }
}
