using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity: Activity
{
    //private int _count = 0;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base()
    {

    }

    public ListingActivity(string name, string description) : base(name, description)
    {
  
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
        int _count = 0;
        
        
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("=> ");
            Console.ReadLine();
            _count++;
        } 

        Console.WriteLine($"\nYou listed {_count} items.");

        stopwatch.Stop();

        DisplayEndingMessage();
        
    }    

    
    // public List<string> GetListFromUser() 
    // {

    // }


}   