using System;

class Program
{
    static void Main(string[] args)
    {     
        
        string quit = "";

        string book = "Proverbs";
        int chapter = 3;
        int verse = 5;
        int endVerse = 6;
        string scriptureVerse = "Trust in the LORD with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
                
             
        Reference reference = new Reference(book, chapter, verse, endVerse);
        
        Scripture scripture = new Scripture(reference, scriptureVerse);

        while (quit != "quit" && !scripture.IsCompletlyHidden())
        {

            Console.Clear();
            Console.WriteLine("Welcome to Scripture Memorizer!");
            Console.WriteLine();
            scripture.GetDisplayText();
            Console.WriteLine();

            Console.WriteLine();
            
            bool HideW = scripture.HideRandomWords();
            Console.WriteLine($"{HideW}");

            Console.WriteLine("Press Enter to continue or type 'quit' to finish: ");
            quit = Console.ReadLine();       
        }
       
    }
}