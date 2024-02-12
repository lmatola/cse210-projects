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
                BreathingActivity breathingactivity = new BreathingActivity();
                breathingactivity.Run();
            }

            else if (choice == 2)
            {
                ReflectingActivity reflectingactivity = new ReflectingActivity();
                reflectingactivity.Run();
            }

            else if (choice == 3)
            {
                ListingActivity listingactivity = new ListingActivity();
                listingactivity.Run();
            }

            else
            {
                Console.WriteLine("You chose to quit the program.");
            }

        }    
    }
}