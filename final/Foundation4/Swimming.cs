using System;

public class Swimming : Activity
{
    private int _swimmingLaps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _swimmingLaps = laps;
    }

    public override double GetDistance()
    {
        return _swimmingLaps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _activityLength) * 60;
    }

    public override double GetPace()
    {
        return _activityLength / GetDistance();
    }
}