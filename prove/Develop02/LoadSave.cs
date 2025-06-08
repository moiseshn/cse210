using System.Collections.Generic;
using System.IO;

public class LoadSave
{
    // Attribute
    // public string _filename;
    // public List<string> _entries = new List<string>();

    // Constructor
    public LoadSave()
    {

    }
    // Method
    public void ReadFromFile(string filename) 
    {
        Console.WriteLine("Loading from file... ");
        Console.WriteLine("Here are the loaded entries:\n");
        string[] loadEntries = System.IO.File.ReadAllLines(filename);

        foreach (string i in loadEntries)
        {
            string[] parts = i.Split("~");
            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
            string localIp = parts[3];

            Console.WriteLine($"Date: {date}, Prompt: {prompt}, Entry: {entry}, Local IP: {localIp}");
        }
    }
    
    public void SaveToFile(string filename, List<string> entries)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {

            // Calls the list of entries for the output
            foreach (string entrie in entries)
            {
                outputFile.WriteLine(entrie); // As formated in myEntries._entries
            }
            // foreach(Entry x in entries) // This approach requires pulling variables from Main()
            // {
            //     outputFile.WriteLine($"{x.date}~{x.prompt}~{x.answer}");
            // }
        }
        Console.WriteLine("Saving to file... ");
    }
}
/*

    public List<string> EntryToList(string date, string prompt, string entry, string localIp)
    {
        _date = date;
        _prompt = prompt;
        _entry = entry;
        _localIp = localIp;
        _entriesList.Add($"{date}~{prompt}~{entry}~{localIp}");
        // return $"Date: {date} - {prompt} {entry}";
        return _entriesList;
    }
*/