using System;

public class Assignment
{
    // Attributes
    private string _studentName;
    private string _topic;
    // Constructors
    public Assignment()
    {

    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    // Methods
    public string GetStudentName() // Getter for private attribute
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}