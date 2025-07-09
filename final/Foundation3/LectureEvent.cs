using System;
public class LectureEvent : Event
{
    // Attributes
    private string _speaker;
    private int _capacity;

    // Constructors
    public LectureEvent(string title, string description, string date, string time, string speaker, int capacity) : base(title, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Methods
    public override string DisplayShortText()
    {
        // type of event, title, and the date
        return $"\nEvent Type: {GetType().Name}\nTitle: {_title}\nDate: {_date}";
    }
    public override string DisplayStandardText()
    {
        // title, description, date, time, and address
        return $"\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.DisplayAddress()}";
    }

    public override string DisplayFullText()
    {
        // event type, title, description, date, time, and address + specificvattributes
        return $"\nEvent Type: {GetType().Name}\nSpeaker: {_speaker}\nCapacity: {_capacity}\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.DisplayAddress()}";
    }
}