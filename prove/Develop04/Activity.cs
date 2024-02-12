using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name = " ";
    protected string _description = " ";
    protected int _duration = 0;
    private List<string> animationStrings = new List<string>()
    {"|", "-", "\\", "/", "_"};
  

    public Activity()
    {

    }

     public string GetName()
    {
        return _name;
    }


    public void SetName(string name)
    {
        _name = name;
    }


    public string GetDescription()
    {
        return _description;
    }


    public void SetDescription(string description)
    {
        _description = description;
    }

    
    public int GetDuration()
    {
        return _duration;
    }


    public void SetDuration(int duration)
    {
        _duration = duration;
    }


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
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
        GetPauseAnimation(5);
        Console.WriteLine("\n");
        
    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        GetPauseAnimation(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        GetPauseAnimation(5);
    }

    public void GetTimer(int duration) // Used in the Reflecting and Observation class activities
    {        
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


    public void GetPauseAnimation(int duration)
    {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;
        int x = 0;
        Console.CursorVisible = false;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[x];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            x = i % 4;

        }
        Console.CursorVisible = true;
    }
    
    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        Console.CursorVisible = false;
        while (DateTime.Now < futureTime)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
        Console.CursorVisible = true;

    }

}