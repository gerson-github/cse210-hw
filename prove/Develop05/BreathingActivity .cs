public class BreathingActivity : Activity
{
    public void Run()
    {
        _name = "Breathing Activity";
        _description = "A breathing exercise to relax and focus.";
        DisplayStartingMessage();
        ShowCountDown(3); // Countdown before starting

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4); // Breathe in for 4 seconds
            Console.WriteLine("Breathe out...");
            ShowCountDown(4); // Breathe out for 4 seconds
        }

        DisplayEndingMessage();
    }
}