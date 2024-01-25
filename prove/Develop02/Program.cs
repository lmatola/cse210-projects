using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {  
        int choice = 0;
        string answer = " ";
        bool Continue = true;

        
        do
        { 
            Random random = new Random();
            string[] promptQuestions = {
            
            "What steps did you take today towards a goal you're working on?",
            "What the thing are you grateful today?",        
            "What kind of food would you like taste today?",
            "What are the thing you have done that are you most proud of today?",
            "Where is your favorite place to ralax?",
            "Where do you see yourself in the future moments?",
            "What was the best thing that happened to you today?",
            "What negative emotions am I holding onto?",        
            "What do you want to be remembered for?", 
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "How did I see the hand of the Lord in my life today?",
            "If I had one thing I could do over today, what would it be?"
            };                          
            
            // Generate random indexes for promptQuestions.
            int index = random.Next(promptQuestions.Length);         

            // Display the Intro info.
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to the Journal program!");
            Console.WriteLine("Please select one of the following choices:");

            // Display the Menu.     
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you want to do? ");
            string x = Console.ReadLine();
            choice = int.Parse(x);

            Entry entry = new Entry();
            entry._promptText = promptQuestions[index];
            Console.WriteLine(entry._promptText);    

            Console.Write("> ");
            string entryUser = Console.ReadLine();
            entry._entryText = entryUser;        

            // Display the datetime
            DateTime theCurrentTime = DateTime.Now;
            entry._date = theCurrentTime.ToShortDateString();     

            Journal journal = new Journal();
            //journal._entries.Add(entry);
            //journal._entries = new List<Entry>();
            journal.AddEntry(entry);  
            journal.DisplayAll();         

   
         
        if (choice == 1) 
        {
            journal.AddEntry(entry);
        }

        else if (choice == 2)
        {
            journal.DisplayAll();
        }
        
        else if (choice == 3) 
        {
            journal.LoadFromFile();
        }

        else if (choice == 4) 
        {
            journal.SaveToFile();
        }

        else
        {
            Console.WriteLine("Thanks for using our journal !");

            Console.Write("Do you want to continue? type YES/NO ");
            answer = Console.ReadLine();
            answer = answer.ToUpper();
            
            if (answer == "YES")
            {
                Continue = true;
            }

            else 
            {
                Continue = false;                    
            }  
        }                
                
       }while(Continue);
    }    
}

