using System;

class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are some things you are grateful for today?",
        "What are some of your favorite memories?",
        "What are some places that make you feel peaceful?",
        "What are some activities that bring you joy?",
        "What are some accomplishments you are proud of?",
        "What does the fox say?"
    };

    public ListingActivity()
    {
        activityName = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Get ready to begin your listing exercise...");
        ShowSpinner(3);

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Begin listing your thoughts. Press Enter after each thought you want to write about is complete. Type 'done' when you finish.");

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }
            itemCount++;
        }

        Console.WriteLine($"You shared {itemCount} thoughts. Great Work! Continue to think about these things throughout your day.");
        End();
    }
}