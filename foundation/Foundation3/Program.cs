using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Clear();
        
        Console.WriteLine("Hello Foundation3 World!");

        // Create a list to hold activities
        List<Activity> activities = new List<Activity>();

        // Add activities to the list
        activities.Add(new Running(DateTime.Now, 30, 5)); // 5 km running
        activities.Add(new Cycling(DateTime.Now, 45, 20)); // 20 km cycling
        activities.Add(new Swimming(DateTime.Now, 30, 20)); // 20 laps swimming

        

        // Iterate through the list and display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}