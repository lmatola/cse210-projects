using System;
using System.IO;
using System.Collections.Generic;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();    

      public void AddEntry(Entry newEntry)
    {        
        _entries.Add(newEntry);  
          
    }

    public void DisplayAll() 
    {
        foreach (Entry entry in _entries)
        {
            // This calls the Display method on each entry
            entry.Display();
                        
        }
        Console.WriteLine(" ");        
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
