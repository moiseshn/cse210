using System;
using System.Text.RegularExpressions;
// Keeps track of a single word and whether it is shown or hidden.

public class Word
{
    // Attributes
    private string[] _wordList;
    private string _text;
    private string _isHiddenWord;
    private List<int> _hiddenIndex;

    // Constructors
    // This constructor should likely accept the text of the word to save it as an attribute. 
    // In addition, the constructor will need to set the initial visibility of the word (whether it is shown or hidden). 
    // Is this something that the user should pass in directly, or can the constructor just assign a value?
    public Word(string text)
    {
        _text = text;
        // _singleWord = words;
        // _isHiddenWord = true;
    }
    public Word(string text, string isHidden)
    {
        _text = text;
        _isHiddenWord = isHidden;
    }

    // Methods
    // has the responsibility for storing the text of a word and whether it is hidden or not.
    public void HideWord()
    {
        var random = new Random();
        var index = random.Next(_wordList.Length);
        if (_hiddenIndex.Contains(index))
        {
            HideWord();
        }
        else
        {
            _hiddenIndex.Add(index);
        }
    }
    public void ShowWord(string text)
    {
        _text = text;
        Console.Clear();
        Console.WriteLine(text);
        for (var i = 0; i < _wordList.Length; i++)
        {
            var word = _wordList[i];
            int len = word.Length;
            string underDashed = new String('_', len);
            if (_hiddenIndex.Contains(i))
            {
                Console.WriteLine($"{underDashed} ");
            }
            else
            {
                Console.WriteLine($"{word} ");
            }
        }
    }
    public void IsHidden()
    {

    }
    public string GetRenderedText()
    {
        _wordList = _text.Split(" ");
        _hiddenIndex = new List<int>();
        return $"{_hiddenIndex}";
    }
}
