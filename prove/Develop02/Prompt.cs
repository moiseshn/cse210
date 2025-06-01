using System.Collections.Generic;

public class Prompt
{
    // Attributes
    private List<string> _prompts = new List<string>
    {
        "Write about someone you interacted with today!",
        "Any challenge today to write about?",
        "What would you have done differently today?",
        "What was today's highlight?",
        "What could have been a spitual esence this day?"
    };
    private string _pickedPrompt; 

    // Constructor
    public Prompt()
    {

    }

    //  Methods
    public string RandomPrompt() // Changed from void to return _pickedPrompt
    {
        Random randomPrompt = new Random();
        int indexNumber = randomPrompt.Next(_prompts.Count);
        _pickedPrompt = _prompts[indexNumber];
        // Console.WriteLine(_pickedPrompt); // Not needed *******************
        return _pickedPrompt; 
    }
}

/*
Random from Lists Reference:
https://www.bytehide.com/blog/random-elements-csharp#:~:text=Practical%20Examples%3A%20Retrieving%20Random%20Elements%20From%20Lists,-Say%20you%20have&text=In%20C%23%2C%20you%20would%20do,random%20index%20int%20index%20%3D%20rnd.
*/