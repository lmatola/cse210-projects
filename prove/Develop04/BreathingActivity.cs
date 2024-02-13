using System;
using System.Collections.Generic;
using System.Threading;

public class BreathingActivity: Activity
{
    private int _breatheInTime = 0;
    private int _breatheOutTime = 0;

    public BreathingActivity() : base()
    {
    
    }

    public BreathingActivity(string name, string description, int breatheInTime, int breatheOutTime) : base(name, description)
    {
        _breatheInTime = breatheInTime;
        _breatheOutTime = breatheOutTime;
        
    }


    public void Run()
    {
       Console.Clear();
       DisplayStartingMessage();
       Console.WriteLine();

       int duration = _duration;
       while (duration > 0)
       {
            Console.Write("Breath in.....");
            ShowCountDown(_breatheInTime);
            Console.WriteLine("\n");
            Console.Write("Breath out.....");
            ShowCountDown(_breatheOutTime);
            Console.WriteLine("\n");
            duration -= _breatheInTime + _breatheOutTime;
       }

       DisplayEndingMessage();
    }

}