using System;

class SwimmingActivity : Activity
{
    private int _laps; // number of laps
    private const double _lapLengthKm = 0.05; // 50 meters = 0.05 km

    public SwimmingActivity(string description) : base("Swimming", description)
    {
    }

    public void SetLaps(int laps)
    {
        if (laps <= 0)
        {
            throw new ArgumentException("The number of laps must be a positive integer.");
        }
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance = number of laps * lap length
        return _laps * _lapLengthKm;
    }

    public override double GetSpeed()
    {
        // Speed = Distance / Time (in hours)
        return GetDistance() / (_duration / 60.0);
    }

    public override double GetPace()
    {
        // Pace = Time / Distance (minutes per km)
        return _duration / GetDistance();
    }
}