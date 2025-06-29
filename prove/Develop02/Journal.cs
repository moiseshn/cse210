using System;
using System.Runtime.CompilerServices;

public class Journal
{
    // Attributes
    public List<Entry> _entries;
    public List<Prompt> _prompts;

    // Constructor
    public Journal()
    {
        _entries = new List<Entry>();
        _prompts = new List<Prompt>();
    }
    
    // Method
    // public void addEntryToJournal(string date, string prompt, string answer)
    // {
    //     Entry entry = new Entry(date, prompt, answer);
    //     _entries.Add(entry);
    // }
    public void DisplayJournal()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
 
}