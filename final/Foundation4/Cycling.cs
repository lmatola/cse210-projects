using System;

public class Cycling : Activity
{
    private double _cyclingSpeed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _cyclingSpeed = speed;
    }

    public override double GetDistance()
    {
        return _cyclingSpeed * (_activityLength / 60);
    }

    public override double GetSpeed()
    {
        return _cyclingSpeed;
    }

    public override double GetPace()
    {
        return _activityLength / GetDistance();
    }
}