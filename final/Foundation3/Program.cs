using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Lecture lecture = new Lecture("Climate change and its effects on RN", "Understand how climate change affects Rio Grande do Norte with increased temperatures, reduced rainfall, extreme weather events and coastal threats.", "September 15, 2024", "4:45 p.m.", "75 3rd Ave", "New York", "NY 10003", "USA", "Prof. Cristian Prestrelo", 250);

        Console.WriteLine("Standard Details:");
        lecture.StandardDisplay();

        Console.WriteLine();
        Console.WriteLine("Full Description:");
        lecture.GetDescription();

        Console.WriteLine("Short Description:");
        lecture.ShortDescription();

        Console.WriteLine("=============================================================================");

        Reception reception = new Reception("Bang Entertainment and GrooveBeet Reception", "Join us as we celebrate the partnership between Bang Entertainment and GrooveBeet", "September 25, 2024", "8:00 p.m.", "29 Washington Pl", "New York", "NY 10003", "USA", "bangbeet@entertainment.edu");

        Console.WriteLine("Standard Details:");
        reception.StandardDisplay();

        Console.WriteLine();
        Console.WriteLine("Full Description:");
        reception.GetDescription();

        Console.WriteLine("Short Description:");
        reception.ShortDescription();

        Console.WriteLine("=============================================================================");

        Outdoor outdoor = new Outdoor("Mr. & Mrs. Matola's Outdoor Wedding", "Join us as we celebrate the union of Lazaro Matola and Viginia Mondlane as man and wife", "June 15, 2024", "3:00 p.m.", "400 Broome St", "New York", "NY 10013", "USA", "Temperatures in the low 45s to high 75s with bright sun.");

        Console.WriteLine("Standard Details:");
        outdoor.StandardDisplay();

        Console.WriteLine();
        Console.WriteLine("Full Description:");
        outdoor.GetDescription();

        Console.WriteLine("Short Description:");
        outdoor.ShortDescription();
    }
}