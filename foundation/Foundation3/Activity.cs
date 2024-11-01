using System;
using System.Collections.Generic;

// Base class
public abstract class Activity
{
    // Private member variables
    private DateTime date;
    private int duration; // in minutes

    // Constructor
    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    protected int Duration => duration;

    // Virtual methods to be overridden in derived classes
    public abstract double GetDistance();
    public abstract string GetSpeed();
    public abstract double GetPace();

    // Get summary method
    public virtual string GetSummary()
    {
        return $"Date: {date.ToString("dd-MM-yyyy")} Running {duration} minutes - Distance {GetDistance()} km, Speed {GetSpeed()} km/h, Pace {GetPace()} min/km";
    }
}
