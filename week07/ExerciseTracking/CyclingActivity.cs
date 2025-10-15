using System;

class CyclingActivity : Activity
{
    private double _speed; // in kilometers per hour

    public CyclingActivity(string description) : base("Cycling", description)
    {
    }

    public void SetSpeed(double speed)
    {
        if (speed <= 0)
        {
            throw new ArgumentException("The speed must be a positive number.");
        }
        _speed = speed;
    }

    public override double GetDistance()
    {
        // Distance = Speed * Time (in hours)
        return _speed * (_duration / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // Pace = 60 / Speed (minutes per km)
        return 60.0 / _speed;
    }
}