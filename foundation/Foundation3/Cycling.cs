public class Cycling : Activity
{
    private double distance; // in kilometers

    public Cycling(DateTime date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override string GetSpeed() => ((distance / (double)(base.Duration)) * 60).ToString("F1"); // km/h

    public override double GetPace() => (double)base.Duration / distance; // min/km
}