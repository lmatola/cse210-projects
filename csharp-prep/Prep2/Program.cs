using System;

class Program
{
    static void Main(string[] args)
    {
        // Core Requirements 1
        Console.Write("What is your grade percentage? ");
        string GradePercentage = Console.ReadLine();
        int x = int.Parse(GradePercentage);

        
        if (x >= 90)
        {
            Console.WriteLine("A");
        }
        else if (90 > x && x >= 80)
        {
            Console.WriteLine("B");
        }
        else if (80 > x && x >= 70)
        {
            Console.WriteLine("C");
        }
        else if (70 > x && x >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        // Core Requirements 2
        if (x >= 70)    
        {
            Console.WriteLine($"your grade is {x}. Congratulation, you passed the course!");
        }    

        else  
        {
            Console.WriteLine($"your grade is {x}. Sorry, you did not passed the course! Try next time");
        } 



        // Core Requirements 3
        
        string letter = "";
        
        if (x >= 90)
        {
            letter = "A";                    

        }
        else if (90 > x && x >= 80)
        {
            letter = "B"; 
        }
        else if (80 > x && x >= 70)
        {
            letter = "C"; 
        }
        else if (70 > x && x >= 60)
        {
            letter = "D"; 
        }
        else
        {
            letter = "F"; 
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (x >= 70)    
        {
            Console.WriteLine($"your grade is {x}. Congratulation, you passed the course!");
        }    

        else  
        {
            Console.WriteLine($"your grade is {x}. Sorry, you did not passed the course! Try next time");
        } 
    }
}