using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the ExerciseTracking Program.");
        Console.WriteLine("Here is the report for all Activities- Running, Cycling, and Swimming:");
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("Today's Date: " + DateTime.Now.ToShortDateString());
        Console.WriteLine();

        // Create a list to hold all activities
        List<Activity> activities = new List<Activity>();

        // Create a Running activity
        RunningActivity running = new RunningActivity("Morning jog in the park");
        running.SetDuration(30);
        running.SetDistance(4.8);
        activities.Add(running);

        // Create a Cycling activity
        CyclingActivity cycling = new CyclingActivity("Evening bike ride");
        cycling.SetDuration(45);
        cycling.SetSpeed(20.0);
        activities.Add(cycling);

        // Create a Swimming activity
        SwimmingActivity swimming = new SwimmingActivity("Lap swimming at the pool");
        swimming.SetDuration(25);
        swimming.SetLaps(40);
        activities.Add(swimming);

        // Iterate through the list and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}