using System;

class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

     // Example of Constructors. 
    public Resume ()
        {
               
        }

    public void Display()
    {
        Console.WriteLine(" ");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.DisplayJobDetails();
                        
        }
        Console.WriteLine(" ");

        
    }
}  
