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

        int halfDuration = duration / 2;
        for (int i = 0; i < halfDuration; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.Write("Breathe out... ");
            ShowCountdown(6);
        }

        End();
    }
}