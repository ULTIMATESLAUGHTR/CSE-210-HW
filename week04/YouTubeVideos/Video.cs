using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;

    // Public properties with proper encapsulation
    public string Title 
    { 
        get { return _title; } 
        private set { _title = value; } 
    }
    
    public string Author 
    { 
        get { return _author; } 
        private set { _author = value; } 
    }
    
    public int LengthInSeconds 
    { 
        get { return _lengthInSeconds; } 
        private set { _lengthInSeconds = value; } 
    }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Length: {LengthInSeconds} seconds");
    }
    
    // Get comments for this video from the Comment class repository
    public List<Comment> GetComments()
    {
        return Comment.GetCommentsForVideo(Title);
    }
    
    public void DisplayComments()
    {
        Console.WriteLine($"Comments for {Title}:");
        var comments = GetComments();
        foreach (var comment in comments)
        {
            comment.DisplayComment();
        }
    }
}