using System;
public abstract class Goal
{
    // Attributes
    // protected string _goalType;
    protected string _goalName;
    protected string _goalDetails;
    protected int _goalPoints;
    protected int _bonus;
    // protected int _score;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDetails = description;
        _goalPoints = points;
    }

    // Methods
    public abstract void RegisterGoalEvent();
    public abstract bool IsCompleted();
    public abstract string GetSavingFormat();
    // Getters
    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetGoalDescription()
    {
        return _goalDetails;
    }
    public int GetGoalPoints()
    {
        return _goalPoints;
    }
    public int GetGoalBonus()
    {
        return _bonus;
    }
}