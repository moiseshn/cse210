using System.Collections.Generic;
using System.IO;

public class Save
{
    // Attributes
    private string _filename;
    private List<string> _entries;

    // Constructors
    public Save(string fileName, List<string> entries)
    {
        _filename = fileName;
        _entries = entries;
    }
    // Methods
    public string GetFilename()
    {
        // Asks the user to type the name of the file to be saved with.
        Console.WriteLine("\nType the filename to save: ");
        _filename = Console.ReadLine();
        return _filename;
    }
    public void SaveToFile(string completeRegistry)
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            // Calls the list of entries for the output
            foreach (string entrie in _entries)
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