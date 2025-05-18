using System.Collections.Generic;
using System.IO;

public class Save
{
    // Method requires two parameters: user input filename, a list of entries
    public void SaveToFile(string filename, List<string> entries) 
    {
        Console.WriteLine("Saving to file... ");
        using (StreamWriter outputFile = new StreamWriter(filename))
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
    }
}