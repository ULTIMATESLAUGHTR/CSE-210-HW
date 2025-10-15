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

        
        List<Activity> activities = new List<Activity>();

        // Here's the mock running activity.
        RunningActivity running = new RunningActivity("Morning jog in the park");
        running.SetDuration(30);
        running.SetDistance(4.8);
        activities.Add(running);

        // Here's the mock cycling activity.
        CyclingActivity cycling = new CyclingActivity("Evening bike ride");
        cycling.SetDuration(45);
        cycling.SetSpeed(20.0);
        activities.Add(cycling);

        // This one's a lap Swimming activity
        SwimmingActivity swimming = new SwimmingActivity("Lap swimming at the pool");
        swimming.SetDuration(25);
        swimming.SetLaps(40);
        activities.Add(swimming);

        // This will print the summary for each activity.
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}