using System;

class PromptGenerator
{
    public string[] _prompts = {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced today and how you overcame it.",
        "What is something new you learned today?",
        "Reflect on a moment that made you smile today.",
        "What is a goal you have for tomorrow?",
        "Write about someone who made a positive impact on your day.",
        "What is a favorite memory that came to mind today?",
        "Describe a place you would like to visit and why.",
        "What is something you did today that you are proud of?",
        "What is a hobby or activity that brings you joy?",
        "Write about a book, movie, or song that resonated with you recently."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}