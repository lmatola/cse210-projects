using System;

public class Event
{
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private Address _eventAddress;

    public Event(string title, string description, string date, string time, string street, string city, string state, string country)
    {
        _eventTitle = title;
        _eventDescription = description;
        _eventDate = date;
        _eventTime = time;
        _eventAddress = new Address (street, city, state, country);
    }

    public Address DisplayAddress()
    {
        return _eventAddress;
    }

    public void StandardDisplay()
    {
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_eventDescription}");
        Console.WriteLine($"Date: {_eventDate}");
        Console.WriteLine($"Time: {_eventTime}");
        Console.Write($"Address: {DisplayAddress().DisplayAddress()}\n");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"A {this.GetType()} Event");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Date: {_eventDate}\n");
    }
}