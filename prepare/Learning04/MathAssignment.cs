using System;

public class MathAssignment : Assignment
{
    // Attributes
    private string _textbookStection;
    private string _problems;
    // Constructors
    public MathAssignment() : base()
    {

    }
    public MathAssignment(string name, string topic, string bookSection, string problems) : base(name,topic)
    {
        _textbookStection = bookSection;
        _problems = problems;
    }
    // Methods
    public string GetHomeworkList()
    {
        return $"Section {_textbookStection}, Problems {_problems}";
    }
}