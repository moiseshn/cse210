using System;
public class EternalGoal : Goal
{
    // Attributes

    // Constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    { }

    // Methods
    public override void RegisterGoalEvent()
    {
        // _isCompleted = true;
    }
    public override bool IsCompleted()
    {
        return false;
    }
    public override string GetSavingFormat()
    {
        return $"{_goalName},{_goalDetails},{_goalPoints}";
    }
}