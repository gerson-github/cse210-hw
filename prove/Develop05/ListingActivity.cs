public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Name something you're grateful for:",
        "List three things you love about yourself:",
        "What are some of your recent achievements?"
    };

    public void Run()
    {
        _name = "Listing Activity";
        _description = "An activity to list things you value and appreciate.";
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        List<string> responses = GetListFromUser();
        _count = responses.Count;
        
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        string input;
        
        Console.WriteLine("Enter your responses (type 'done' when finished):");
        while ((input = Console.ReadLine())?.ToLower() != "done")
        {
            list.Add(input);
        }
        
        return list;
    }
}