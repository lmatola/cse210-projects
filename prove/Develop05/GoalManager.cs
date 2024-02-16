using System;
using System.IO;

public class GoalManager

{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    
    public GoalManager()
    {
        _score = 0;
    }


    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }


    public int GetScore()
    {
        return _score;
    }


    public void AddPoints(int points)
    {
        _score += points;
    }


    public void AddBonus(int bonus)
    {
        _score += bonus;
    }


    public void SetScore(int score)
    {
        _score = score;
    }


    public List<Goal> GetGoalsList()
    {
        return _goals;
    }


    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine();
            Console.WriteLine("\nYour Goals are:");

            int index = 1;
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }

        else
        {
            Console.WriteLine("You currently have no goals!");
        }
    }


    public void RecordGoalEvent()
    {
        ListGoals();
        Console.WriteLine();
        Console.Write("Which goal did you accomplished? ");
        int select = int.Parse(Console.ReadLine())-1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(_goals);

        Console.WriteLine($"You have {GetScore()} points!.");
    }


    public void SaveGoals()
    {
        Console.Write("What is the name for this goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            outputFile.WriteLine(GetScore());
            foreach (Goal goal in _goals)
            {
                string goalString = " ";
                goalString += goal.GetGoalType();
                goalString += ", ";
                goalString += goal.GetName();
                goalString += ", ";
                goalString += goal.GetDescription();
                goalString += ", ";
                goalString += goal.GetPoints();
                goalString += ", ";
                goalString += goal.IsComplete();
                goalString += ", ";
                outputFile.WriteLine($"{goalString}");
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the name of your goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            int score = int.Parse(readText[0]);
            AddPoints(score);
            readText = readText.Skip(1).ToArray();
            foreach (string line in readText)
            {
                string[] data = line.Split(", ");

                string goalType = data[0];
                string shortName = data[1];
                string description = data[2];
                int points = int.Parse(data[3]);
                bool isComplete = Convert.ToBoolean(data[4]);
                
                if (isComplete == true)
                {
                    score += points;
                }

                if (data[0] == "Simple Goal:")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(goalType, shortName, description, points, isComplete);
                    AddGoal(simpleGoal);
                }
                if (data[0] == "Eternal Goal:")
                {
                    EternalGoal eternalGoal = new EternalGoal(goalType, shortName, description, points, isComplete);
                    AddGoal(eternalGoal);
                }
                if (data[0] == "Check List Goal:")
                {
                    int target = int.Parse(data[5]);
                    int bonus = int.Parse(data[6]);
                    int counter = int.Parse(data[7]);

                    CheckListGoal checkListGoal = new CheckListGoal(goalType, shortName, description, points, isComplete, target, bonus, counter);
                    AddGoal(checkListGoal);
                }
            }
               Console.Write($"You currently have {score} points\n");
        }
    }
}