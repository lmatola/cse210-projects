using System;

public class CheckListGoal : Goal
{
    private string _goalType = "Check List Goal:";
    private int _target;
    private int _bonus;
    private int _amountCompleted;


    // public CheckListGoal(string goalType, string shortName, string description, int points, int target, int bonus, bool isComplete) : base(goalType, shortName, description, points, isComplete)
    // {
    //     _target = target;
    //     _bonus = bonus;
    //     _amountCompleted = 0;
    // }


    public CheckListGoal(string goalType, string shortName, string description, int points, bool isComplete, int target, int bonus, int amountCompleted) : base(goalType, shortName, description, points, isComplete)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }


    public int GetTarget()
    {
        return _target;
    }


    public void SetTarget()
    {
        _amountCompleted = _amountCompleted + 1;
    }


     public int GetAmountCompleted()
    {
        return _amountCompleted;
    }


     public int GetBonus()
    {
        return _bonus;
    }


    public override void GetDetailsString(int i)
    {
        if (IsComplete() == false)
        {
            Console.WriteLine($"{i}. [] {GetName()} ({GetDescription()})  --  Currently Completed: {GetAmountCompleted()}/{GetTarget()}");
        }
        else
        {
            Console.WriteLine($"{i}. [x] {GetName()} ({GetDescription()})  --  Completed: {GetAmountCompleted()}/{GetTarget()}");
        }
    }


    public override string GetStringRepresentation()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {IsComplete}; {GetTarget()}; {GetBonus()}; {GetAmountCompleted()}");
    }


    public override string LoadGoal()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {IsComplete}; {GetTarget()}; {GetBonus()}; {GetAmountCompleted()}");
    }

    
    public override void RecordGoalEvent(List<Goal> goals)
    {
        SetTarget();
        int points = GetPoints();

        if (_amountCompleted == _target)
        {
            points = points + _bonus;
  
            Console.WriteLine($"Congratulations! You have earned {points} points");
        }
        else if (IsComplete() == true)
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
        }
    }

}