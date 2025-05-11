using System.Collections.Generic;
public class Entry
{
    public List<string> _entries = new List<string>();

    public void DisplayEntries()
    {
        foreach (string i in _entries)
        {
            Console.WriteLine(i);
        }
    }
}