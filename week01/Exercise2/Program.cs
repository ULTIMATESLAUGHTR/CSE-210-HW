using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        GraderProgram grader = new GraderProgram();
        grader.GradingProgram();

    }
}

class GraderProgram
{
    public void GradingProgram()
    {
        Console.Write("Enter your course score: ");
        string input = Console.ReadLine();
        
        // Try to parse the input as a double
        if (double.TryParse(input, out double score))
        {
            string letter; // I used this Variable to store the letter grade
            
            // Used this to determine letter grade using if-else if-else structure.
            if (score >= 90)
            {
                letter = "A";
            }
            else if (score >= 80)
            {
                letter = "B";
            }
            else if (score >= 70)
            {
                letter = "C";
            }
            else if (score >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
            
            // Single print statement for the letter grade
            Console.WriteLine($"Your letter grade is: {letter}");
            
            // Pass/fail message
            if (score >= 70)
            {
                Console.WriteLine("Congratulations! You passed the class.");
            }
            else
            {
                Console.WriteLine("Try again harder next time");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}