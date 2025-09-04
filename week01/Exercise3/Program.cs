using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        GuessingNumberGame game = new GuessingNumberGame();
        game.Main();
    }
}

class GuessingNumberGame
{
    public void Main()
    {
        bool playAgain = true;
        
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100.");
        
        while (playAgain)
        {
            PlayGame();
            playAgain = AskPlayAgain();
        }
        
        Console.WriteLine("Thanks for playing you're awesome!");
    }
    
    static void PlayGame()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // This gives us a Random number between 1-100
        int guess = 0;
        int attempts = 0;
        bool hasGuessedCorrectly = false;
        
        Console.WriteLine("\nNew game started! Guess the number between 1 and 100:");
        
        while (!hasGuessedCorrectly)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            
            // Validate input
            if (int.TryParse(input, out guess))
            {
                attempts++;
                
                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Please enter a number between 1 and 100.");
                    continue;
                }
                
                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try a higher number.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high! Try a lower number.");
                }
                else
                {
                    hasGuessedCorrectly = true;
                    Console.WriteLine($"\nCongratulations! You guessed the number {secretNumber} correctly!");
                    Console.WriteLine($"It took you {attempts} attempts.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
    }
    
    static bool AskPlayAgain()
    {
        while (true)
        {
            Console.Write("\nDo you want to play again? Type: (yes or no): ");
            string response = Console.ReadLine().ToLower().Trim();
            
            if (response == "yes" || response == "yes")
            {
                return true;
            }
            else if (response == "no" || response == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter 'yes' for yes, or 'no' for no.");
            }
        }
    }
}