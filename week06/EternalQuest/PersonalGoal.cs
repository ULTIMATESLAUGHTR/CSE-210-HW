using System;

public class PersonalGoal
{
    private GoalTracker _tracker;

    public PersonalGoal(GoalTracker tracker)
    {
        _tracker = tracker;
    }

    public void SetGoal()
    {
        bool keepGoing = true;
        while (keepGoing)
        {
            Console.WriteLine("Welcome to the Personal Goal Tracker!");
            Console.WriteLine("Write down your personal Goal. If you complete it, you'll earn 10 points!");
            string goal = Console.ReadLine();
            _tracker.SetPersonalGoal(goal);
            _tracker.LoadTitles();
            _tracker.DisplayStatus();

            Console.WriteLine("Did you complete your personal goal? type 'yes' or 'no'");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                Console.WriteLine("Congratulations on completing your personal goal! You've earned 10 points.");
                _tracker.AddPoints(10);
                _tracker.SaveTitles();
            }
            else
            {
                Console.WriteLine("No worries! Keep going! Once you do, you'll earn those points and feel good too!");
                _tracker.DisplayStatus();
            }

            Console.WriteLine("Would you like to log another personal goal? (yes/no)");
            string another = Console.ReadLine().ToLower();
            if (another != "yes")
            {
                keepGoing = false;
            }
        }
    }
}