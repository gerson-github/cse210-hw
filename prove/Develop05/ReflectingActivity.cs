public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you helped someone in need.",
        "Recall a time when you accomplished a challenging goal."
    };

    private List<string> _questions = new List<string>
    {
        "What did you learn from that experience?",
        "How did it make you feel afterward?",
        "How could you apply what you learned to your future actions?"
    };

    public void Run()
    {
        _name = "Reflecting Activity";
        _description = "An activity to reflect on positive experiences.";
        DisplayStartingMessage();

        DisplayPrompt();
        DisplayQuestions();

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    private void DisplayQuestions()
    {
        Console.WriteLine("Reflect on the following questions:");
        foreach (string question in _questions)
        {
            Console.WriteLine($"- {question}");
        }
    }
}