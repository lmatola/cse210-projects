public class BreathingActivity: Activity
{
    private int _breatheInTime = 5;
    private int _breatheOutTime = 5;

    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
       Console.Clear();
       DisplayStartingMessage();
       Console.WriteLine();

       int duration = _duration;
       while (duration > 0)
       {
            Console.Write("Breath in...");
            ShowCountDown(_breatheInTime);
            Console.WriteLine("\n");
            Console.Write("Breath out...");
            ShowCountDown(_breatheOutTime);
            Console.WriteLine("\n");
            duration -= _breatheInTime + _breatheOutTime;
       }

       DisplayEndingMessage();
    }

}