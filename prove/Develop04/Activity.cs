using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name = " ";
    protected string _description = " ";
    protected int _duration = 0;
    private List<string> _animation = new List<string>()
    {"|", "-", "\\", "/", "_"};
  
    public Activity()
    {

    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
              
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("\n");
        
    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void GetTimer(int duration)
    {   
        _duration = duration;      
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b\b \b");
            duration--;
        }
    }

    public void ShowSpinner(int duration)
    {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;
        int x = 0;
        Console.CursorVisible = false;
        while (DateTime.Now < endTime)
        {
            string str = _animation[x];
            Console.Write(str);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;
            x = i % 4;

        }
        Console.CursorVisible = true;
    }
    
    public void ShowCountDown(int duraction)
    {

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duraction);
        Console.CursorVisible = false;
        while (DateTime.Now < futureTime)
        {
            Console.Write(duraction);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            duraction--;
        }
        Console.CursorVisible = true;

    }

}