using System;

public abstract class Goal
{
    private string _goalType;
    private string _shortName;
    private string _description;
    private int _points;
    private bool _isComplete;

    public Goal(string goalType, string shortName, string description, int points, bool isComplete)
    {
        _goalType = goalType;
        _shortName = shortName;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }
    public string GetGoalType()
    {
        return _goalType;
    }    
    
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public bool IsComplete()
    {
        return _isComplete;
    }

    public abstract void ListGoal(int i);
    public abstract string GetStringRepresentation();
    public abstract string LoadGoal();
    public abstract void RecordGoalEvent(List<Goal> goals);
}