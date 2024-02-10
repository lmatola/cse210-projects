using System;

public class SimpleGoal: Goal 
{
    private bool _isComplete;

    public SimpleGoal() 
    {
        
    } 


    public SimpleGoal( string shortName, string description, int points, bool isComplete) : base(shortName,description,points)
    {
        _isComplete = IsComplete();
    } 

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        
    }

    public override bool IsComplete()
    {
        return false;
    } 

    public override string GetStringRepresentation()
    {
        string goalType = GetType().Name;
        return ($"{goalType},{_shortName},{_description},{_points}");
    }

}
