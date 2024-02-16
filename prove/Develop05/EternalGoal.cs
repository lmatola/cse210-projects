using System;

public class EternalGoal : Goal
{
    private string _goalType = "Eternal Goal:";

    
    public EternalGoal(string goalType, string shorteName, string description, int points, bool isComplete) : base(goalType, shorteName, description, points, isComplete)
    {

    }


    public override void GetDetailsString(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }


    public override string GetStringRepresentation()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {IsComplete()}");
    }


    public override string LoadGoal()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {IsComplete()}");
    }


      public override void RecordGoalEvent(List<Goal> goals)
    {
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
    }


}