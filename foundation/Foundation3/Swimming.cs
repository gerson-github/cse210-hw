public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0; // in kilometers

    public override string GetSpeed() => (GetDistance() / (double)base.Duration * 60).ToString("F1"); // km/h

    public override double GetPace() => (double)base.Duration / GetDistance(); // min/km
}