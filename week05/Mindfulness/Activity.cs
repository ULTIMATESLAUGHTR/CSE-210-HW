using System;

public class Activity
{
    protected string activityName;
    protected string description;
    protected int duration;

    public Activity()
    {
        activityName = "Generic Activity";
        description = "This is a generic mindfulness activity.";
        duration = 0;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        Console.Write("Enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"The activity will last for {duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b/");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b-");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b\\");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b ");
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public virtual void End()
    {
        Console.WriteLine($"You have completed the {activityName} for {duration} seconds. Good Job! Keep up the good work!");
        ShowSpinner(3);
    }
}