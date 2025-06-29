using System;
public class SimpleGoal : Goal
{
    // Attributes
    private bool _isCompleted;

    // Constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        // For goal creation from file
    }
    // Methods
    public override void RegisterGoalEvent()
    {
        _isCompleted = true;
    }
    public override bool IsCompleted()
    {
        return _isCompleted;
    }
    public override string GetSavingFormat()
    {
        return $"{_goalName},{_goalDetails},{_goalPoints},{IsCompleted()}";
    }
    // public void CreateGoalFromFile()
    // {

    // }
}