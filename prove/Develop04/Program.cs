using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        int choice = 0;
        
        while (choice != 4)
        {   
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity:");
            Console.WriteLine("  2. Start reflecting activity:");
            Console.WriteLine("  3. Start listing activity:");
            Console.WriteLine("  4. Quit");

            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");
            string x = Console.ReadLine();
            choice = int.Parse(x);

            if (choice==1)
            {
                BreathingActivity breathingactivity = new BreathingActivity("Breathing Activity",
                "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.", 5, 5);
                breathingactivity.Run();
            }

            else if (choice == 2)
            {
                ReflectingActivity reflectingactivity = new ReflectingActivity("Reflecting Activity",
                "This activity will help you reflect on times in your life when you have shown strength and resilience.  \nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingactivity.Run();
            }

            else if (choice == 3)
            {
                ListingActivity listingactivity = new ListingActivity("Listing Activity",
                "This activity will help you reflect on the good things in your life by having yout list as many things as you can in a certain area.");
                listingactivity.Run();
            }

            else
            {
                Console.WriteLine("You chose to quit the program thanks for your time.");
            }
            Console.WriteLine();

        }    
    }
}