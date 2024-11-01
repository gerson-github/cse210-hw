using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Start the main menu loop
    public void Start()
    {
        bool running = true;
        while (running)
        {
            DisplayMenu();
            int choice = GetMenuChoice();
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    Save("Goal.txt");
                    break;
                case 4:
                    Load("Goal.txt");
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    running = false;
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nSelect the type of goal you like to create:\n");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int choice = GetMenuChoice();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points asscoiated with this goal? ");
        string input = Console.ReadLine();

        int points = int.TryParse(input, out points) ? points : 0;



        Goal newGoal = choice switch
        {
            1 => new SimpleGoal(name, description, points),
            2 => new EternalGoal(name, description, points),
            3 => CreateChecklistGoal(name, description, points),
            _ => null
        };

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully.");
            PressKeyToContinue();
        }
        else
        {
            Console.WriteLine("Invalid choice. Goal creation cancelled.");
            PressKeyToContinue();
        }
    }

    private ChecklistGoal CreateChecklistGoal(string name, string description, int points)
    {
        Console.Write("Enter target count for completion: ");
        int target = int.Parse(Console.ReadLine()); // Use int.TryParse for safer parsing
        Console.Write("Enter bonus points for completion: ");
        int bonus = int.Parse(Console.ReadLine()); // Use int.TryParse for safer parsing
        return new ChecklistGoal(name, description, points, target, bonus);
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe Goals are:\n");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        PressKeyToContinue();
    }

    public void ListGoalNames() 
    {
        Console.WriteLine("\nThe Goals are:\n");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
        }
    }

    private void PressKeyToContinue()
    {
        Console.WriteLine("\nPress a key to continue...\n");
        Console.ReadKey();
    }

    private int GetMenuChoice()
    {
        return int.TryParse(Console.ReadLine(), out int choice) ? choice : -1;
    }

     private void DisplayMenu()
    {
        
        Screen screen = new Screen();
        screen.ShowHeader(_score);
        
        Console.WriteLine("\nEternal Quest Menu Options:\n");
        Console.WriteLine("1. Create New goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("\nChoose an option: ");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nEnter the number of the goal you accomplished: \n");
        //int goalIndex = int.Parse(Console.ReadLine()) - 1;

        string input = Console.ReadLine();
        int goalIndex = 0;
        
        if (int.TryParse(input, out goalIndex))
        {
            if (goalIndex >= 0 && goalIndex <= _goals.Count)
            {
               _goals[goalIndex -1].RecordEvent();  
               int pointsAwarded = _goals[goalIndex -1].GetPoint(); 
                _score += pointsAwarded;
                 Console.WriteLine($"\nEvent recorded. You earned {pointsAwarded} points.\n");
            }
            else
            {
                Console.WriteLine("Invalid goal number. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("\nPlease type a numeric value.");
        }
        PressKeyToContinue();      
    }

    
    public void Save(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {

            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully. File named Goal.txt was created !");
        PressKeyToContinue();      
    }

    public void Load(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("Save file not found.");
            return;
        }

        using (StreamReader reader = new StreamReader(fileName))
        {
            _score = int.Parse(reader.ReadLine());
            _goals.Clear();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                Goal goal = parts[0] switch
                {
                    "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])),
                    "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])),
                    "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6])),
                    _ => null
                };
                if (goal is SimpleGoal simpleGoal)
                {
                    simpleGoal.SetCompletionStatus(bool.Parse(parts[4]));
                }
                if (goal is ChecklistGoal checklistGoal)
                {
                    checklistGoal.SetAmountCompleted(int.Parse(parts[4]));
                }                
                if (goal != null) _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }


    



    // // Record an event for a goal
    // public void RecordEvent()
    // {
    //     ListGoalNames();
    //     Console.Write("Enter the number of the goal you accomplished: ");
    //     int goalIndex = int.Parse(Console.ReadLine()) - 1;

    //     if (goalIndex >= 0 && goalIndex < _goals.Count)
    //     {
    //         _goals[goalIndex ].RecordEvent();
    //         int pointsAwarded = _goals[goalIndex]._points;
    //         if (_goals[goalIndex] is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
    //         {
    //             pointsAwarded += checklistGoal._bonus;
    //         }
    //         _score += pointsAwarded;
    //         Console.WriteLine($"Event recorded. You earned {pointsAwarded} points.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid goal number. Please try again.");
    //     }
    // }

    // // Save goals to a file
    // public void SaveGoals(string fileName)
    // {
    //     using (StreamWriter writer = new StreamWriter(fileName))
    //     {
    //         writer.WriteLine(_score);
    //         foreach (var goal in _goals)
    //         {
    //             writer.WriteLine(goal.SaveString());
    //         }
    //     }
    //     Console.WriteLine("Goals saved successfully.");
    // }

    // // Load goals from a file
    // public void LoadGoals(string fileName)
    // {
    //     if (!File.Exists(fileName))
    //     {
    //         Console.WriteLine("Save file not found.");
    //         return;
    //     }

    //     using (StreamReader reader = new StreamReader(fileName))
    //     {
    //         _score = int.Parse(reader.ReadLine());
    //         _goals.Clear();
    //         string line;
    //         while ((line = reader.ReadLine()) != null)
    //         {
    //             string[] parts = line.Split('|');
    //             Goal goal = parts[0] switch
    //             {
    //                 "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]))
    //                 {
    //                     _isComplete = bool.Parse(parts[4])
    //                 },
    //                 "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])),
    //                 "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]))
    //                 {
    //                     _amountCompleted = int.Parse(parts[4])
    //                 },
    //                 _ => null
    //             };
    //             if (goal != null) _goals.Add(goal);
    //         }
    //     }
    //     Console.WriteLine("Goals loaded successfully.");
    // }

    // // Display menu options
    //

    

}
