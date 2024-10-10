using System;
using System.IO; 
using System.Text.Json;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
       foreach(Entry entry in _entries)
       {
        Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
        Console.WriteLine(entry._entryText);
        Console.WriteLine();
       }
       Console.ReadKey();
    }
    public void SaveToFile(string file)
    {

        if (!file.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
        {
            file += ".txt";
        }
        
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date.PadRight(10)}{entry._promptText.PadRight(65)}{entry._entryText.PadRight(500)}");
            }
        }
    }
    public void SaveToJson(string file)
    {
         //string jsonString = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
        try
        {

            var options = new JsonSerializerOptions()
            {
                IncludeFields = true,
                WriteIndented = true,
            };
            string content = JsonSerializer.Serialize(_entries, options);

            // Write the JSON string to the specified file
            File.WriteAllText(file, content);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }


    }

    public void LoadFromFile(string file)
    {
        
        _entries.Clear();
        string[] rows = File.ReadAllLines(file);

        foreach(string row in rows)
        {
            if (row.Length >= 575)
            {
                string _date = row.Substring(0,10).Trim();
                string _prompt = row.Substring(10,65).Trim();
                string _text = row.Substring(75,500).Trim();

                Entry newEntry = new Entry();
                newEntry._date = _date;
                newEntry._promptText = _prompt;
                newEntry._entryText = _text;            
                _entries.Add(newEntry);
            }
            else
            {
                Console.WriteLine("Invalid file!");
            }
            

        }
        
    }


}