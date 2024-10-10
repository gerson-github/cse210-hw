using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    private Journal _journal;
    private PromptGenerator _promptGenerator;
    private Screen _screen;
    
    // Correct constructor definition with parentheses
    public Program()
    {
        _journal = new Journal();
        _promptGenerator = new PromptGenerator();
        _screen = new Screen();
    }

    private void Write()
    {
        string prompt = _promptGenerator.GetrandomPrompt();
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string userText = Console.ReadLine();

        Entry _entry = new Entry();
        _entry._date = DateTime.Now.ToString("dd-MM-yyyy");
        _entry._promptText = prompt;
        _entry._entryText = userText;
        _journal.AddEntry(_entry);
    }

    private void Load()
    {
        string fileName = getFileName();

        if (!string.IsNullOrEmpty(fileName))
        {

            //  exists?
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File does not exist.");
            } else {
                _journal.LoadFromFile(fileName);
                Console.WriteLine("Loaded successfully !");
            }
        }
        Console.ReadKey();

    }
    private void Save()
    {

        string fileName = getFileName();

        if (!string.IsNullOrEmpty(fileName))
        {
            _journal.SaveToFile(fileName);
            Console.WriteLine("Saved successfully!");
        }
        Console.ReadKey();

    }

    private void SaveToJson()
    {

        string fileName = getFileName();

        if (!string.IsNullOrEmpty(fileName))
        {
            _journal.SaveToJson(fileName);
            Console.WriteLine("Saved successfully!");
        }
        Console.ReadKey();

    }


    private void Quit()
    {
        Console.WriteLine(@"
        You’ve taken a great step in reflecting on your day. Thank you for using the Journal app! 
        See you next time!
        
        ");
    }

    private string getFileName()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        if (IsValidFileName(fileName))
        {
            return fileName; // Return valid filename
        }
        else
        {
            return "";
        }
    }

    private bool IsValidFileName(string fileName)
    {
        char[] invalidChars = Path.GetInvalidFileNameChars();
        if (fileName.IndexOfAny(invalidChars) >= 0)
        {
            Console.WriteLine("Invalid filename! Found invalid characters");
            return false;
        }

        // ends with .txt
        // if (!fileName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
        // {
        //     Console.WriteLine("Invalid filename! Missing .txt extension");
        //     return false;
        // }

        string nameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

        // Check before .txt is not empty
        return !string.IsNullOrWhiteSpace(nameWithoutExtension);
    }

    public void Run()
    {
              
        while (true)
        {
            
            int selection = _screen.ShowMenu();

            switch (selection)
            {
                case 1:  //write
                    Write();
                    break;
                case 2:  //display
                    _journal.DisplayAll();
                    break;
                case 3:  //load
                    Load();
                    break;
                case 4: //save
                    Save();
                    break;
                case 5: //save
                    SaveToJson();
                    break;
                case 6: //quit
                    Quit();
                    return;
            }   
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("ow I am here");
        Program app = new Program();  // create instance of Program class
        app.Run();
        
    }


}
