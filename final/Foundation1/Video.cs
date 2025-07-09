using System;
using System.Collections.Generic;
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _length = lengthSeconds;
    }
    // Getters
    // public string GetTitle()
    // {
    //     return _title;
    // }
    // public string GetAuthor()
    // {
    //     return _author;
    // }
    // public int GetLength()
    // {
    //     return _length;
    // }

    // Methods
    public int GetCommentsCount()
    {
        return _comments.Count;
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments: {GetCommentsCount()}");
        Console.WriteLine($"List of Comments: ");
        foreach (var comment in _comments)
        {
            Console.WriteLine($" > {comment.DisplayComment()}");
        }
    }
}