using System;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

// Keeps track of the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.
public class Scripture
{
    // Attributes
    // member variables for a reference and all of the words in the scripture.
    private string _reference;
    private string _text;

    // Constructors
    // will need a constructor that accepts both a reference and the text of the scripture. 
    // If the Scripture class internally stores a List of Word objects, the first thought 
    // would be to pass a List<Word> variable to the constructor. While this could work, 
    // it may be easier to use the class by passing the text of the scripture as a single 
    // string with all of the words in it. Then, the constructor would have the responsibility 
    // of creating the list, and splitting up the words in the string to create Word objects 
    // for each one and put them in the list.
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
        // List<string> wordList = text.Split(" ").ToList();
        List<Word> wordList = new List<Word>(); // calls the Word class's behavior to split, toList.

        foreach (Word word in wordList)
        {
            word.HideWord();
            word.ShowWord(_text);
            word.IsHidden();
            // Console.WriteLine(word.GetRenderedText());
        }
    }

    // Methods
    // has the responsibility to keep track of the reference, the text, and to hide the words.
    public string GetRenderedScripture()
    {
        /*
                // split text to list
                List<string> wordList = _text.Split(" ").ToList();
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
        */

        return $"{_reference} {_text}";
        // return String.Concat(wordList);  // This joins into a single string a list of words.
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

/*
ATTRIBUTES:
- Every member variable should be private. 

CONSTRUCTORS:
- The constructor of a class must have the same name as the class name in which it resides.
- A class can have any number of constructors.
- A constructor can not be abstract, final, and Synchronized.
- A constructor doesn’t have any return type.
https://www.geeksforgeeks.org/c-sharp-constructors/

METHODS:
- Getters and Setters should be used to access the data.
- Getters should not have any parameters and should not prompt the user for anything, but instead, simply return a value.
- Setters should accept a single parameter and have a void return type.
*/
