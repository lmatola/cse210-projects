using System;

class Program
{
    static void Main(string[] args)
    {
        
        string words = "Trust in the LORD with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        
        //char [] delimiters = new char [] {" ", ";", ",", "."};

        foreach (var item in words.Split(" "));
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");     
        
        
        
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        Word word = new Word();
    }
}