using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity:");
        Console.WriteLine("  1. Start reflecting activity:");
        Console.WriteLine("  1. Start listing activity:");
        Console.WriteLine("  4. Quit");

        Console.WriteLine();

        Console.WriteLine("Select a choice from the menu:");

        BreathingActivity breathingactivity = new BreathingActivity();
        breathingactivity.Run();

        ReflectingActivity reflectingactivity = new ReflectingActivity();
        reflectingactivity.Run();

        ListingActivity listingactivity = new ListingActivity();
        listingactivity.Run();

    }
}