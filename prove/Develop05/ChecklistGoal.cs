using System;
public class ChecklistGoal : Goal
{
    // Attributes
    private int _totalTasksRequired;
    private int _totalTasksDone;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int bonus, int totalTasksRequired) : base(name, description, points)
    {
        _bonus = bonus;
        _totalTasksRequired = totalTasksRequired;
        _totalTasksDone = 0;
    }
    public ChecklistGoal(string name, string description, int points, int bonus, int totalTasksRequired, int totalTasksDone) : base(name, description, points)
    {
        // For goal creation from file
    }
    // Getters
    public int GetTotalTasksRequired()
    {
        return _totalTasksRequired;
    }
    public int GetTotalTasksDone()
    {
        return _totalTasksDone;
    }

    // Methods
    public override void RegisterGoalEvent()
    {
        _totalTasksDone++;
    }
    public override bool IsCompleted()
    {
        return _totalTasksDone >= _totalTasksRequired;
    }
    public override string GetSavingFormat()
    {
        return $"{_goalName},{_goalDetails},{_goalPoints},{_bonus},{_totalTasksRequired},{_totalTasksDone}";
    }
}