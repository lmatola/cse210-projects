using System;

public class Reception : Event
{
    private string _emailAddress;

    public Reception(string title, string description, string date, string time, string street, string city, string state, string country, string email) : base(title, description, date, time, street, city, state, country)
    {
        _emailAddress = email;
    }

    public void GetDescription()
    {
        Console.WriteLine($"A {this.GetType()} Event");
        StandardDisplay();
        Console.WriteLine($"Please RSVP to: {_emailAddress}\n");      
    }
}