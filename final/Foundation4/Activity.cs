using System;
using System.Collections.Generic;

public abstract class Activity
{
    protected string _activityDate;
    protected int _activityLength;
    protected List<Activity> _activityList;

    public Activity(string date, int minutes)
    {
        _activityDate = date;
        _activityLength = minutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();
    
    public abstract double GetPace();
    

    public string GetSummary()
    {
        return $"{_activityDate} {this.GetType().Name} ({_activityLength} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}