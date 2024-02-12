using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
    {
       _name = "Listing Activity";
       _description = "This activity will help you reflect on the good things in your life by having yout list as many things as you can in a certain area.";
    }

    public int GetCount()
    {
        return _count;
    }

    public void SetCount(int count)
    {
        _count = count;
    }

    public List<string> GetPrompt()
    {
        return _prompts = new List<string>();
    }

    public void SetPrompt(List<string> prompt)
    {
        _prompts = prompt;
    }


    public string GetRandomPrompt() 
    {     
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        
        Console.WriteLine(GetRandomPrompt());
       
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int counter = 0;
        
        
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("=> ");
            Console.ReadLine();
            counter++;
        } 

        Console.WriteLine($"\nYou listed {counter} items.");

        stopwatch.Stop();

        DisplayEndingMessage();
        
    }
    

    
    // public List<string> GetListFromUser() 
    // {

    // }


}   