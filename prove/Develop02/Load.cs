using System.Collections.Generic;
using System.IO;

public class Load
{
    public List<string> ReadFromFile(string filename)
    {
        Console.WriteLine("Loading from file... ");
        Console.WriteLine("Here are the loaded entries:\n");
        List<string> loadEntries = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line); // Chage code to split by delimeter ************* Following video
            // string[] parts = line.Split("~~");  // ie. "12/31/2024~~Write SomethingGood!~~Alright then."
            // Entry myEntries = new Entry();
            // myEntries._myDate = parts[0];
            // myEntries._myPrompt = parts[1];
            // myEntries._myAnswer = parts[2];
            // loadEntries.Add(myEntries);
        }
        return loadEntries;
    }
}

/*

*/