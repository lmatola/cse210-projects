using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;


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


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} - {_description}");
        SetDuration();

        Console.WriteLine("Prepare to begin...");
        PauseForSeconds(3);
    }


    public void DisplayEndingMessage()
    {

    }

    
    public void ShowSpinner(int seconds)
    {

    }


    public void ShowCountDown(int seconds)
    {

    }

}