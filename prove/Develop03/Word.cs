using System;
using System.Text.RegularExpressions;
// Keeps track of a single word and whether it is shown or hidden.

public class Word
{
    // Attributes
    public string _text;
    public bool _isHiddenWord;

    // Constructors
    // This constructor should likely accept the text of the word to save it as an attribute. 
    // In addition, the constructor will need to set the initial visibility of the word (whether it is shown or hidden). 
    // Is this something that the user should pass in directly, or can the constructor just assign a value?
    public Word(string text)
    {
        _text = text;
        _isHiddenWord = false;
    }

    // Methods
    // has the responsibility for storing the text of a word and whether it is hidden or not.
    public void HideWord()
    {
        _isHiddenWord = true;
        // _text = text;
        // _numberOfWordsToHide = numberOfWordsToHide;

        // List<string> words = text.Split(" ").ToList();
        // Random random = new Random();
        // for (int i = 0; i < numberOfWordsToHide; i++)
        // {
        //     int index = random.Next(words.Count);
        //     words[index] = new string('_', words[index].Length);
        // }
        // var random = new Random();
        // var index = random.Next(_wordList.Length);
        // if (_hiddenIndex.Contains(index))
        // {
        //     HideWord();
        // }
        // else
        // {
        //     _hiddenIndex.Add(index);
        // }
        // return words;
    }
    public void ShowWord()
    {
        _isHiddenWord = false;
        // _text = text;
        // Console.Clear();
        // Console.WriteLine(text);
        // for (var i = 0; i < _wordList.Length; i++)
        // {
        //     var word = _wordList[i];
        //     int len = word.Length;
        //     string underDashed = new String('_', len);
        //     if (_hiddenIndex.Contains(i))
        //     {
        //         Console.WriteLine($"{underDashed} ");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{word} ");
        //     }
        // }
    }
    public bool IsHiddenWord()
    {
        return _isHiddenWord;
    }
    public string GetRenderedText()
    {
        return _isHiddenWord ? "___" : _text;
        // _wordList = _text.Split(" ");
        // _hiddenIndex = new List<int>();
        // return $"{_hiddenIndex}";
    }
}
