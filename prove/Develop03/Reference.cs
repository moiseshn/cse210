using System;
// Keeps track of the book, chapter, and verse information.

public class Reference
{
    // Attributes
    // for the book, chapter, and verse, as well as a second "end verse"
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructors
    // have at least two different constructors to account for cases where there is a single verse or multiple verses. 
    public Reference(string bookName, int chapterNum, int verseNum)
    {
        _book = bookName;
        _chapter = chapterNum;
        _verse = verseNum;
    }
    public Reference(string bookName, int chapterNum, int verseNum, int lastVerse)
    {
        _book = bookName;
        _chapter = chapterNum;
        _verse = verseNum;
        _endVerse = lastVerse;
    }
    // Methods
    public string GetReferenceText()
    {
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}