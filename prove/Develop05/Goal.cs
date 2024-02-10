using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;   

    public Goal()
    {

    }

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetshortName()
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

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return " ";
    }

    public abstract string GetStringRepresentation();
}


