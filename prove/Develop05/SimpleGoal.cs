using System;

public class SimpleGoal : Goal
{
    private string _type = "Simple Goal:";
    public SimpleGoal(string goalType, string shortName, string description, int points, bool isComplete) : base(goalType, shortName, description, points, isComplete)
    {

    }
    public override void ListGoal(int i)
    {
        if (IsComplete() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
        }
        else if (IsComplete() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})");
        }
    }
    public override string GetStringRepresentation()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {IsComplete}");
    }
    public override string LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {IsComplete}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
       if (IsComplete() == true)
       {
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
       }
    }

}