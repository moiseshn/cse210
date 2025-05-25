using System;

public class Reference
{
    // Attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructors
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