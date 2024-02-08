using System;

class Program
{
    static void Main(string[] args)
    {     
        
        //Scripture scripture = new Scripture();

        // ListOfScripture listOfScripture = new ListOfScripture();        
        // listOfScripture.ScriptureAdd(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."));
                

        // Reference reference = new Reference("Proverbs", 3, 5, 6);
        // reference.DisplayText();  

        // Console.WriteLine(reference.DisplayText());

        string quit = "";

        Console.WriteLine("Welcome to Scripture Memory");   

        string book = "Proverbs";
        string chapter = "3";
        string verse = "5";
        string endVerse = "6";
        string scripture = "Trust in the LORD with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
                
        Reference reference = new Reference(book, chapter, verse, endVerse);
        
        Scripture scripture = new Scripture(reference,scripture);

        while (quit != "quit" && !scripture.IsCompletlyHidden())
        {

            Console.Clear();
            scripture.GetRenderedText();

            Console.WriteLine();
            Console.WriteLine();
            
            bool HidedW = scripture.HideWords();
            Console.WriteLine($"{HideW}");

            Console.Write("Enter 'quit' to quit: ");
            quit = Console.ReadLine();       
        }
       
    }
}