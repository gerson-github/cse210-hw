public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting { _name }");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        ShowSpinner(3);
        Console.WriteLine($"Good job! You completed the { _name } for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
         for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b");
        }

    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}