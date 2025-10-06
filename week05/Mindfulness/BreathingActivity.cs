using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        activityName = "Breathing Activity";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Get ready to begin your breathing exercise...");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            if (DateTime.Now >= endTime) break;

            Console.Write("Breathe out... ");
            ShowCountdown(6);
        }

        End();
    }
}