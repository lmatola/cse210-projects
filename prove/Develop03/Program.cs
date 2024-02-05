using System;

class Program
{
    static void Main(string[] args)
    {     
        
        //Scripture scripture = new Scripture();

        ListOfScripture listOfScripture = new ListOfScripture();        
        listOfScripture.ScriptureAdd(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."));
                

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        reference.GetDisplayText();  

        Console.WriteLine(reference.GetDisplayText());       
        
       
    }
}