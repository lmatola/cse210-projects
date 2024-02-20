using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        List<Activity> _activityList = new List<Activity>();

        Running running = new Running("07/31/2024", 80, 3);
        _activityList.Add(running);

        Cycling cycling = new Cycling("08/25/2024", 180, 4.6);
        _activityList.Add(cycling);

        Swimming swimming = new Swimming("08/05/2024", 75, 50);
        _activityList.Add(swimming);

        foreach(Activity activity in _activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine();

    }
}