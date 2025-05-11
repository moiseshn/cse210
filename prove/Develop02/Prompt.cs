using System.Collections.Generic;

public class Prompt
{
    public List<string> _prompts = new List<string>();
    public string _pickedPrompt;
    public void RandomPrompt(List<string> _prompts)
    {
        Random randomPrompt = new Random();
        int indexNumber = randomPrompt.Next(_prompts.Count);
        // Added this line to save the random pick to a string variable.
        _pickedPrompt = _prompts[indexNumber];
        Console.WriteLine(_pickedPrompt);
    }
}

/*
Random from Lists Reference:
https://www.bytehide.com/blog/random-elements-csharp#:~:text=Practical%20Examples%3A%20Retrieving%20Random%20Elements%20From%20Lists,-Say%20you%20have&text=In%20C%23%2C%20you%20would%20do,random%20index%20int%20index%20%3D%20rnd.
*/