using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime date;
    private double durationMinutes;

    public Activity(DateTime date, double durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    protected double DurationMinutes => durationMinutes;

    public virtual double GetDistance() { return 0; }
    public virtual double GetSpeed() { return 0; }
    public virtual double GetPace() { return 0; }

    public string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} ({GetType().Name}): Duration {durationMinutes} min - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}

public class Running : Activity
{
    private double distanceMiles;

    public Running(DateTime date, double durationMinutes, double distanceMiles)
        : base(date, durationMinutes)
    {
        this.distanceMiles = distanceMiles;
    }

    public override double GetDistance() => distanceMiles;
    public override double GetSpeed() => (distanceMiles / DurationMinutes) * 60;
    public override double GetPace() => DurationMinutes / distanceMiles;
}

public class Cycling : Activity
{
    private double speedMph;

    public Cycling(DateTime date, double durationMinutes, double speedMph)
        : base(date, durationMinutes)
    {
        this.speedMph = speedMph;
    }

    public override double GetDistance() => (speedMph * DurationMinutes) / 60;
    public override double GetSpeed() => speedMph;
    public override double GetPace() => 60 / speedMph;
}

public class Swimming : Activity
{
    private int numberOfLaps;

    public Swimming(DateTime date, double durationMinutes, int numberOfLaps)
        : base(date, durationMinutes)
    {
        this.numberOfLaps = numberOfLaps;
    }

    public override double GetDistance() => numberOfLaps * 50 / 1000 * 0.62;
    public override double GetSpeed() => GetDistance() / (DurationMinutes / 60);
    public override double GetPace() => DurationMinutes / GetDistance();
}

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2023, 11, 3), 30, 20.0),
            new Swimming(new DateTime(2023, 11, 3), 30, 12)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}