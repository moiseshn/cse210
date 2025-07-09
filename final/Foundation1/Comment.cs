using System;
public class Comment
{
    private string _userName;
    private string _userText;

    // Constructor
    public Comment()
    { }
    public Comment(string name, string comment)
    {
        _userName = name;
        _userText = comment;
    }
    
    // Getters
    // public string GetCommentorsName()
    // {
    //     return _userName;
    // }
    // public string GetCommentText()
    // {
    //     return _userText;
    // }

    // Setters
    public void SetCommentorsName(string name)
    {
        _userName = name;
    }
    public void SetCommentorsText(string text)
    {
        _userText = text;
    }
    // Method
    public string DisplayComment()
    {
        return $"{_userName}: {_userText}";
    }
}