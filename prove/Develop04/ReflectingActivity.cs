using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompt = new List<string>()
    {"Think of a time when you stood up for someone else.",
     "Think of a time when you did something really difficult.",
     "Think of a time when you helped someone in need.",
     "Think of a time when you did something truly selfless."
    };
    private List<string> _question = new List<string>()
    {"Why was this experience meaningful to you?",
     "Have you ever done anything like this before?",
     "How did you get started?",
     "How did you feel when it was complete?",
     "What made this time different than other times when you were not as successful?",
     "What is your favorite thing about this experience?",
     "What could you learn from this experience that applies to other situations?",
     "What did you learn about yourself through this experience?",
     "How can you keep this experience in mind in the future?"
    };

    // Constructor
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.  \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        
    }

    // Methods
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompt.Count);
        return _prompt[index] ;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_question.Count);
        return _question[index];
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine("Think about this prompt for a moment:\n");
        Console.WriteLine($">{GetRandomPrompt()}");
        Console.WriteLine("\nPress enter when you are ready.");
        Console.ReadLine();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int counter = 0;
        Console.CursorVisible = false;
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.WriteLine(GetRandomQuestion());
            GetTimer(10);
            counter++;
        } 

        stopwatch.Stop();
        Console.CursorVisible = true;
        DisplayEndingMessage();


    }
}