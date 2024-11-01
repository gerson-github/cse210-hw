using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Develop06 World!");

 
         GoalManager goalManager = new GoalManager();
         goalManager.Start();

//         goalManager.CreateGoal(new SimpleGoal("Run a marathon", "Complete a full marathon", 1000));
//         goalManager.AddGoal(new EternalGoal("Read Scriptures", "Read daily", 100));
//         goalManager.AddGoal(new ChecklistGoal("Attend Temple", "Attend the temple", 50, 10, 500));

        // Sample Menu Loop
        // bool running = true;
        // while (running)
        // {
        //     Console.WriteLine("\nEternal Quest Menu");
        //     Console.WriteLine("1. Display Player Info");
        //     Console.WriteLine("2. List Goal Details");
        //     Console.WriteLine("3. Record Event");
        //     Console.WriteLine("4. Save Goals");
        //     Console.WriteLine("5. Load Goals");
        //     Console.WriteLine("6. Quit");
        //     Console.Write("Choose an option: ");

        //     int choice = int.Parse(Console.ReadLine());
        //     switch (choice)
        //     {
        //         case 1:
        //             goalManager.DisplayPlayerInfo();
        //             break;
        //         case 2:
        //             goalManager.ListGoalDetails();
        //             break;
        //         case 3:
        //             Console.Write("Enter the goal index to record event for: ");
        //             int index = int.Parse(Console.ReadLine());
        //             goalManager.RecordEvent (index);
        //             break;
        //         case 4:
        //             goalManager.SaveGoals("goals.txt");
        //             break;
        //         case 5:
        //             goalManager.LoadGoals("goals.txt");
        //             break;
        //         case 6:
        //             running = false;
        //             break;
        //         default:
        //             Console.WriteLine("Invalid option.");
        //             break;
        //     }
        // }

    }
}