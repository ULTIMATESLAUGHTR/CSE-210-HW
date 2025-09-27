using System;
using System.Collections.Generic;

public class Comment
{
    // Individual comment details and set privately for encapsulation requirements.
    public string CommenterName { get; private set; }
    public string CommentText { get; private set; }
    public string VideoTitle { get; private set; }

    // Static list of all comments for all videos
    private static Dictionary<string, List<Comment>> _allVideoComments;

    // Static constructor to compile the comment repository
    static Comment()
    {
        InitializeComments();
    }

    // Constructor for individual comments on each video
    public Comment(string commenterName, string commentText, string videoTitle)
    {
        CommenterName = commenterName;
        CommentText = commentText;
        VideoTitle = videoTitle;
    }

    // Compiles all comments for all videos
    private static void InitializeComments()
    {
        _allVideoComments = new Dictionary<string, List<Comment>>();

        
        var sampleVideoComments = new List<Comment>
        {
            new Comment("User1", "Great video!", "Sample YoutubeVideo"),
            new Comment("User2", "Very informative", "Sample YoutubeVideo"),
            new Comment("User3", "Love this content!", "Sample YoutubeVideo")
        };

        
        var anotherVideoComments = new List<Comment>
        {
            new Comment("Fan123", "Amazing work!", "Another YoutubeVideo"),
            new Comment("Viewer99", "Keep it up!", "Another YoutubeVideo"),
            new Comment("CriticX", "Could be better", "Another YoutubeVideo")
        };

        
        var thirdVideoComments = new List<Comment>
        {
            new Comment("CommentGuru", "Excellent explanation", "Third YoutubeVideo"),
            new Comment("LearnerX", "This helped me a lot", "Third YoutubeVideo"),
            new Comment("VideoFan", "More content like this please", "Third YoutubeVideo")
        };

        
        var fourthVideoComments = new List<Comment>
        {
            new Comment("TechReviewer", "Outstanding quality", "Fourth YoutubeVideo"),
            new Comment("ContentLover", "Subscribed!", "Fourth YoutubeVideo"),
            new Comment("Viewer42", "Nice editing", "Fourth YoutubeVideo")
        };

        // This adds each video's comments to the main collection
        _allVideoComments["Sample YoutubeVideo"] = sampleVideoComments;
        _allVideoComments["Another YoutubeVideo"] = anotherVideoComments;
        _allVideoComments["Third YoutubeVideo"] = thirdVideoComments;
        _allVideoComments["Fourth YoutubeVideo"] = fourthVideoComments;
    }

    // Static method to get comments for a specific video
    public static List<Comment> GetCommentsForVideo(string videoTitle)
    {
        if (_allVideoComments.ContainsKey(videoTitle))
        {
            return new List<Comment>(_allVideoComments[videoTitle]);
        }
        return new List<Comment>();
    }

    // Static method to get all comments for all videos
    public static Dictionary<string, List<Comment>> GetAllComments()
    {
        var copy = new Dictionary<string, List<Comment>>();
        foreach (var kvp in _allVideoComments)
        {
            copy[kvp.Key] = new List<Comment>(kvp.Value);
        }
        return copy;
    }

    
    public void DisplayComment()
    {
        Console.WriteLine($"{CommenterName}: {CommentText}");
    }

    
    public static void AddComment(string videoTitle, string commenterName, string commentText)
    {
        if (!_allVideoComments.ContainsKey(videoTitle))
        {
            _allVideoComments[videoTitle] = new List<Comment>();
        }
        _allVideoComments[videoTitle].Add(new Comment(commenterName, commentText, videoTitle));
    }

    public override string ToString()
    {
        return $"{CommenterName}: {CommentText}";
    }
}