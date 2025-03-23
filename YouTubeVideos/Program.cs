using System;
using System.Collections.Generic;

// Comment class to track the commenter and text
class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}

// Video class to track video details and store comments
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Method to get the list of comments
    public List<Comment> GetComments()
    {
        return _comments;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the videos
        List<Video> videos = new List<Video>();

        // Create first video and add comments
        Video video1 = new Video("C# Programming Tutorial for Beginners", "CodeMaster", 1250);
        video1.AddComment(new Comment("ProgrammingNewbie", "This tutorial really helped me understand C# basics!"));
        video1.AddComment(new Comment("DeveloperJane", "Great explanation of object-oriented concepts."));
        video1.AddComment(new Comment("CodeEnthusiast", "Could you make a follow-up video on LINQ?"));
        video1.AddComment(new Comment("TechLearner", "I appreciate how you broke down complex topics into simple steps."));
        videos.Add(video1);

        // Create second video and add comments
        Video video2 = new Video("10 Must-Know VS Code Shortcuts", "DevTools", 487);
        video2.AddComment(new Comment("EfficientCoder", "These shortcuts saved me so much time!"));
        video2.AddComment(new Comment("ProgrammerBob", "I didn't know about the multi-cursor feature."));
        video2.AddComment(new Comment("CodeMaster", "Great content! I've shared this with my team."));
        videos.Add(video2);

        // Create third video and add comments
        Video video3 = new Video("Building a REST API with ASP.NET Core", "WebDevPro", 1875);
        video3.AddComment(new Comment("APILearner", "Finally understood how to structure my endpoints properly."));
        video3.AddComment(new Comment("BackendDev", "Would love to see a video on authentication with JWT."));
        video3.AddComment(new Comment("FullStackStudent", "This helped me connect my React frontend to my .NET backend."));
        video3.AddComment(new Comment("CloudEngineer", "How would this scale in a microservices architecture?"));
        videos.Add(video3);

        // Create fourth video and add comments
        Video video4 = new Video("Data Structures Explained: Trees and Graphs", "AlgorithmMaster", 1543);
        video4.AddComment(new Comment("CSStudent", "This cleared up my confusion about tree traversal."));
        video4.AddComment(new Comment("InterviewPrepper", "Great examples that will help with coding interviews!"));
        video4.AddComment(new Comment("SelfTaughtDev", "Could you recommend resources to practice these concepts?"));
        videos.Add(video4);

        // Display information for each video
        Console.WriteLine("YouTube Video Program - Product Awareness Tracking");
        Console.WriteLine("=================================================");

        foreach (Video video in videos)
        {
            // Convert seconds to minutes and seconds for display
            int minutes = video.LengthInSeconds / 60;
            int seconds = video.LengthInSeconds % 60;
            
            Console.WriteLine($"\nVideo: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {minutes}:{seconds:D2}");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            
            Console.WriteLine("\nComments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            
            Console.WriteLine("-------------------------------------------");
        }
    }
}