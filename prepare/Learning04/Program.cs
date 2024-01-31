using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(); 
        Assignment assignment = new Assignment();
        assignment.SetName("Samuel Bennett");
        assignment.SetTopic("Multiplication");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();  

        MathAssignment math = new MathAssignment();
        math.SetName("Roberto Rodriguez");
        math.SetTopic("Fractions");
        math.SetTextBookSection("7.3");
        math.SetProblems("8-19"); 
        Console.WriteLine(math.GetHomeWorkList()); 

        Console.WriteLine();  

        WritingAssignment writing = new WritingAssignment();
        writing.SetName("Mary Waters");
        writing.SetTopic("European History");
        writing.SetTitle("The Causes of World War II by Mary Waters");        
        Console.WriteLine(writing.GetWritingInformations());  
        Console.WriteLine(); 
    }
}