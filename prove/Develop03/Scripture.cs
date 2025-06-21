using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

// Keeps track of the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.
public class Scripture
{
    // Attributes
    // member variables for a reference and all of the words in the scripture.
    public Reference _reference;
    private List<Word> _words;
    // private int _wordIndex = 0;

    // Constructors
    // will need a constructor that accepts both a reference and the text of the scripture. 
    // If the Scripture class internally stores a List of Word objects, the first thought 
    // would be to pass a List<Word> variable to the constructor. While this could work, 
    // it may be easier to use the class by passing the text of the scripture as a single 
    // string with all of the words in it. Then, the constructor would have the responsibility 
    // of creating the list, and splitting up the words in the string to create Word objects 
    // for each one and put them in the list.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();

        // List<Word> wordList = new List<Word>(); // calls the Word class's behavior to split, toList.
        // string[] wordList = text.Split(" ");
        // foreach (var word in wordList)
        // {
        //     _words.Add(new Word(word));
            // word.HideWord();
            // word.ShowWord(_words);
            // word.IsHidden();
            // Console.WriteLine(word.GetRenderedText());
        // }
    }

    // Methods
    // has the responsibility to keep track of the reference, the text, and to hide the words.
    public void HideRandom(int numberOfWordsToHide)
    {
        var visibleWords = _words.Where(word => !word.IsHiddenWord()).ToList();
        if (visibleWords.Count <= numberOfWordsToHide)
        {
            foreach (var word in visibleWords)
            {
                word.HideWord();
            }
        }
        else
        {
            Random random = new Random();
            for (int i = 0; i < numberOfWordsToHide; i++)
            {
                int randomizedIndices = random.Next(visibleWords.Count);
                visibleWords[randomizedIndices].HideWord();
                visibleWords.RemoveAt(randomizedIndices);
            }
        }
        // if (_wordIndex < _words.Count)
        // {
        //     List<int> hiddenIndexes = _words
        //     .Select((word, index) => new { Word = word, Index = index })
        //     .Where(item => !item.Word._isHiddenWord)
        //     .Select(item => item.Index)
        //     .ToList();

        //     if (hiddenIndexes.Count > 0)
        //     {
        //         Random random = new Random();
        //         int randomizedIndices = random.Next(0, hiddenIndexes.Count);
        //         _words[hiddenIndexes[randomizedIndices]].HideWord();
        //         _wordIndex++;
        //     }
        // }
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
            return String.Concat(wordList);  // This joins into a single string a list of words.
        */
    }
    public string GetRenderedScripture()
    {
        string renderedScripture = $"{_reference.GetReferenceText()}";
        renderedScripture += string.Join(" ", _words.Select(word => word.GetRenderedText()));
        return renderedScripture;
        // This joins into a single string a list of words.
        // List<string> showWords = _words.ConvertAll(word => word.ToString());
        // string renderedScripture = string.Join(" ", showWords);
        // string renderedReference = _reference.GetReferenceText();
        // return $"{renderedReference}| {renderedScripture}";
    }
    // public string HideWords()
    // {
    //     string x = "";
    //     return x;
    // }
    public bool IsAllHidden()
    {
        return _words.All(word => word.IsHiddenWord());
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
