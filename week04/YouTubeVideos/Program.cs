using System;
using System.Collections.Generic;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the YouTubeVideos Program.");
        Console.WriteLine("=====================================\n");
        
        VideoLibrary videoLibrary = new VideoLibrary();
        DisplayAllVideos(videoLibrary);
        
        // Demonstrate adding a new comment
        Console.WriteLine("\n---New Comments Added ---");
        Comment.AddComment("Sample YoutubeVideo", "NewUser", "Just watched this, amazing!");
        
        Console.WriteLine("Updated comments for 'Sample YoutubeVideo':");
        var updatedComments = Comment.GetCommentsForVideo("Sample YoutubeVideo");
        foreach (var comment in updatedComments)
        {
            Console.WriteLine($"  - {comment}");
        }
    }
    
    static void DisplayAllVideos(VideoLibrary videoLibrary)
    {
        Console.WriteLine("Here are all Videos in the Library:");
        Console.WriteLine("-----------------------------------");
        
        foreach (var video in videoLibrary.GetAllVideos())
        {
            video.DisplayInfo();
        }
        
        Console.WriteLine("\nComments for each Video:");
        Console.WriteLine("------------------------");
        
        // Get all videos and their comments from the Comment class repository
        foreach (var video in videoLibrary.GetAllVideos())
        {
            Console.WriteLine($"\nComments for '{video.Title}':");
            
            // Get comments directly from Comment class
            var comments = Comment.GetCommentsForVideo(video.Title);
            
            if (comments.Count > 0)
            {
                foreach (var comment in comments)
                {
                    Console.WriteLine($"  - {comment.CommenterName}: {comment.CommentText}");
                }
            }
            else
            {
                Console.WriteLine("  - No comments yet");
            }
        }
        
        Console.WriteLine($"\nTotal videos in library: {videoLibrary.GetVideoCount()}");
    }
}