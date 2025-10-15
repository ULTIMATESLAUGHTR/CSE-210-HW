using System;

public abstract class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected DateTime _date;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        _date = DateTime.Now;
    }

    public void SetDuration(int duration)
    {
        if (duration <= 0)
        {
            throw new ArgumentException("The Exercise duration must be a positive number/int.");
        }
        _duration = duration;
    }

    // Here's where I'm putting the Abstract methods to be implemented by derived classes later.
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_activityName} ({_duration} min): Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} k/ph, Pace: {GetPace():F2} min per km";
    }
}