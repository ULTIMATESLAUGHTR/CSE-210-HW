using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello New Player! Welcome to the EternalQuest Game.");
        Console.WriteLine("Before we begin, enter your new super-special-awesome gamer name ^_^ ==>");

        string playerName = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(playerName))
        {
            Console.WriteLine("Please enter a valid gamer name:");
            playerName = Console.ReadLine();
        }
        Console.WriteLine($"Great! Your gamer name is {playerName}. Let's start the adventure!");

        Console.WriteLine("For each goal you'll accomplish you'll earn points. Earning Points levels you up. Which will grant you titles to show off to you and your friends!");
        Console.WriteLine("To Begin, select an option below, using a number, then press the Enter key to confirm your choice:");

        
        var tracker = new SimpleGoalTracker(playerName);

        tracker.LoadTitles();

        while (true)
        {
            Console.WriteLine("\n1. Start Earning Points");
            Console.WriteLine("2. View Current Level, Points, and Titles");
            Console.WriteLine("3. Set a Personal Goal (earns some points btw)");
            Console.WriteLine("4. Save and Exit (please hurry back! I have attachment issues!)");
            Console.Write("Your choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                
                var activity = new ScriptureActivity(playerName);
                activity.StartScriptureActivity();
            }
            else if (choice == "2")
            {
                tracker.DisplayStatus();
            }
            else if (choice == "3")
            {
                
                var goal = new PersonalGoal(playerName);
                goal.SetGoal();
            }
            else if (choice == "4")
            {
                tracker.SaveTitles();
                Console.WriteLine("Thanks for using the EternalQuest Game! Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}