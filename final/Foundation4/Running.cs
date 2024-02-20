using System;

public class Running : Activity
{
    private double _runningDistance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _runningDistance = distance;
    }

    public override double GetDistance()
    {
        return _runningDistance;
    }

    public override double GetSpeed()
    {
        return (_runningDistance / _activityLength) * 60;
    }

    public override double GetPace()
    {
        return (_activityLength / _runningDistance);
    }
}