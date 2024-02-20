using System;

public class Outdoor : Event
{
    private string _weatherForecast;

    public Outdoor(string title, string description, string date, string time, string street, string city, string state, string country, string weatherforecast) : base(title, description, date, time, street, city, state, country)
    {
        _weatherForecast = weatherforecast;
    }

    public void GetDescription() 
    {
        Console.WriteLine($"A {this.GetType()} Event");
        StandardDisplay();
        Console.WriteLine($"Please note the weather forecast: {_weatherForecast}\n");      
    }
}