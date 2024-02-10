using System;

class Program
{
    static void Main(string[] args)
    {
        string _points = "0";

        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine($"You have {_points} points.");
        Console.WriteLine();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals ");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goal");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");

        Console.WriteLine();

        Console.Write("Select a choice from the menu: ");
        string x = Console.ReadLine();
        int choice = int.Parse(x);

        if (choice == 1)
        {
            Console.WriteLine("The types of Goal are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goals ");
            Console.WriteLine("  3. Checklist Goals");
        }

        Console.WriteLine();

        Console.Write("Which type of goal would you like to create? ");
        string y = Console.ReadLine();
        int choice1 = int.Parse(y);

        if (choice1 ==1)
        {
            Console.Write("What is the name of your goal? ");
            Console.ReadLine();

            Console.Write("What is a short description of it? ");
            Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            Console.ReadLine();

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            Console.ReadLine();

            Console.Write("What is the bonus for accomplishing it that many times? ");
            Console.ReadLine();
        }    
             

    }


    
}