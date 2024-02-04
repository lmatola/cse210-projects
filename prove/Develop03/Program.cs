using System;

class Program
{
    static void Main(string[] args)
    {       
        Scripture scripture = new Scripture();

        Reference reference = new Reference();
        reference.SetBook("Proverbs");
        reference.SetChapter(3);
        reference.SetVerse(5);
        reference.SetEndVerse(6);

        Console.WriteLine(reference.GetDisplayText());       
        
        string input = "Trust in the LORD with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        char[] delimiters = {' '};
        string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
 
        Word word = new Word();
        word.SetText(string.Join(" ", words));


        Console.WriteLine(word.GetDisplayText());

        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("_____");
        

        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
       
    }
}