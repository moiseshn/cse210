using System;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    // Attributes
    private string _reference;
    private string _text;

    // Constructors
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
        // split text to list
        List<string> wordList = text.Split(" ").ToList();
        List<int> randomizedIndices = Enumerable.Range(0, wordList.Count).OrderBy(x => Random.Shared.Next()).ToList();

        int doThisMany = 0;

        while (true)
        {
            IEnumerable<string> output =
                wordList
                    .Select((word, index) =>
                        randomizedIndices
                            .Take(doThisMany)
                            .Contains(index)
                                ? Regex.Replace(word, "[a-zA-Z]", "_")
                                : word);
                                
            Console.WriteLine(String.Join(" ", output));
            
            if (wordList.Count == doThisMany)
                break;
                
            doThisMany += Random.Shared.Next(1, wordList.Count - doThisMany);
        }
    }

    // Methods
    public string GetRenderedText()
    {
        return $"{_reference} {_text}";
    }
    public string HideWords()
    {
        string x = "";
        return x;
    }
    public bool IsAllHidden()
    {
        return true;
    }
}

// https://stackoverflow.com/questions/77896952/how-to-choose-random-words-from-a-list-and-hide-them-with-underscores-in-c
