using System;

public class WrittingAssignment : Assignment
{
    // Attributes
    private string _title;
    // Constructors
    public WrittingAssignment() : base()
    {

    }
    public WrittingAssignment(string name, string topic, string title) : base(name,topic)
    {
        _title = title;
    }
    // Methods
    public string GetWrittingInfo()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}