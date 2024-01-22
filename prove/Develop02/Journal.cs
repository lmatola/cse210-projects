using System;
using System.Collections.Generic;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();
    

      public void AddEntry()

    {       
        Console.Write("> ");
        string content = Console.ReadLine();      
    }

    public void DisplayAll() 
    {

        
    }

    public void SaveToFile() 
    {
        string filename = "Journal.txt";

        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"Date: {e}");
            }
            SaveToFile();
        }

    }

    public void LoadFromFile() 
    {
        Console.Write("Reading List: ");
        List<Entry> entries = new List<Entry>();
        string filename = "Journal.txt";
        string [] lines  = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }

        return ;

    }

}
