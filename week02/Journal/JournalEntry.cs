public class JournalEntry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public JournalEntry()
    {
        Date = DateTime.Now.ToShortDateString();
        Prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {Prompt}");
        Console.Write("Your response: ");
        Response = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine(); // Empty line for spacing
    }

    private string GetRandomPrompt()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing I learned today?",
            "What was my favorite moment from today?",
            "What made me smile today?",
            "What challenged me today?",
            "What am I grateful for today?",
            "What is something new I tried today?",
            "What is a goal I have for tomorrow?",
            "What is something I did well today?",
            "What is something I could improve on?",
            "What is a positive habit I want to develop?"
        };
        Random random = new Random();
        return prompts[random.Next(prompts.Length)];
    }
}