using System;

public class CheckListGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private int _goalCounter = 0;  

    public ChecklistGoal()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _points = int.Parse(Console.ReadLine());
    } 


    public CheckListGoal(string shortName, string description, int points, int amountCompleted, int target, int bonus) :base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    } 

    public int GetAmountComplete()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
         int totalPoints = _points + _points;
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
      
        }
       

    }

    public override bool IsComplete()
    {
        return true;
    } 

    public override string GetDetailsString()
    {
        return " ";
    }

    public override string GetStringRepresentation()
    {
         string goalType = GetType().Name;
        return ($"{goalType},{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}");
    }

}


