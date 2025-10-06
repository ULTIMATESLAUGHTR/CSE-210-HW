using System;

class Reflection : Activity

{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you overcame a challenge.",
        "Think of a time when you made a positive impact on someone else's life."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection()
    {
        activityName = "Reflection Activity";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Get ready to begin your reflection exercise...");
        ShowSpinner(3);

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("When you have finished reading the prompt, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on one of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(7);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        
        while (DateTime.Now < endTime)
        {
            string question = questions[rand.Next(questions.Length)];
            Console.WriteLine(question);
            ShowSpinner(10);
            Console.WriteLine();
        }

        End();
    }
}