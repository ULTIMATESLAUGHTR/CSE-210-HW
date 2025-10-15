using System;

class RunningActivity : Activity
{
    private double _distance; // in kilometers

    public RunningActivity(string description) : base("Running", description)
    {
    }

    public void SetDistance(double distance)
    {
        if (distance <= 0)
        {
            throw new ArgumentException("The distance must be a positive number.");
        }
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // Speed = Distance / Time (in hours)
        return _distance / (_duration / 60.0);
    }

    public override double GetPace()
    {
        // Pace = Time / Distance (minutes per km)
        return _duration / _distance;
    }
}