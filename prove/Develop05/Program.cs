using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int menu = 0;
        GoalManager goals = new GoalManager();

        while ( menu != 6)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Eternal Quest Program");
   
            Console.WriteLine();
            Console.WriteLine("Menu Options:");

            Console.WriteLine("  1. Create Goals");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Goal Event");   
            Console.WriteLine("  6. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");
            string user = Console.ReadLine(); 
            menu = int.Parse(user);


            if (menu == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.WriteLine();

                    Console.Write("Witch type of goal would you want to create: ");
                    int userAnswer = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (userAnswer == 1)
                    {
                        Console.Write("What is the name of your goal?  ");
                        string shortName = Console.ReadLine();
                        Console.Write("What is a short description of your goal?  ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal?  ");
                        int points = int.Parse(Console.ReadLine());
                        bool isComplete = false;
                        SimpleGoal simpleGoal = new SimpleGoal("Simple Goal:", shortName, description, points, isComplete);
                        goals.AddGoal(simpleGoal);
                    }

                    if (userAnswer == 2)
                    {
                        Console.Write("What is the name of your goal?  ");
                        string shortName = Console.ReadLine();
                        Console.Write("What is a short description of your goal?  ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal?  ");
                        int points = int.Parse(Console.ReadLine());
                        bool isComplete = false;
                        EternalGoal eternalGoal = new EternalGoal("Eternal Goal:", shortName, description, points, isComplete);
                        goals.AddGoal(eternalGoal);
                    }
                    

                    if (userAnswer == 3)
                    {
                        Console.Write("What is the name of your goal?  ");
                        string shortName = Console.ReadLine();
                        Console.Write("What is a short description of your goal?  ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal?  ");
                        int points = int.Parse(Console.ReadLine());
                        Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for accomplishing it that many times?  ");
                        int bonus = int.Parse(Console.ReadLine());
                        bool isComplete = false;
                        CheckListGoal checkListGoal = new CheckListGoal("Check List Goal:", shortName, description, points, isComplete, target, bonus);
                        goals.AddGoal(checkListGoal);
                    }
                } 

            else if (menu == 2)
            {
                goals.GetGoalsList();
            }

            else if (menu == 3)
            {
                goals.SaveGoals(); 
            }

            else if (menu == 4)
            {
                goals.LoadGoals();                 
            }

            else if (menu == 5)
            {
                Console.Clear();
                Console.WriteLine();  
                Console.Write($"You currently have {goals.GetScore()} points");
                goals.RecordGoalEvent();   
            }
            
            else if (menu == 6)
            {
                Console.Write("See you next time");
            }
        }
    }   
}