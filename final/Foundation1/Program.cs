using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public List<Comment> Comments { get; private set; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return Comments.Count;
    }
}

public class Comment
{
    public string UserName { get; set; }
    public string Text { get; set; }

    public Comment(string userName, string text)
    {
        UserName = userName;
        Text = text;
    }
}

class Program
{
    static void Main()
    {
        // Predefined list of videos
        List<Video> videos = new List<Video>
        {
            new Video("Video Title 1", "Author 1", 300),
            new Video("Video Title 2", "Author 2", 450),
            new Video("Video Title 3", "Author 3", 360)
        };

        // Adding comments to each video
        videos[0].AddComment(new Comment("User1", "Great video!"));
        videos[0].AddComment(new Comment("User2", "Very informative."));

        videos[1].AddComment(new Comment("User3", "Nice explanation."));
        videos[1].AddComment(new Comment("User4", "Helpful tutorial."));

        videos[2].AddComment(new Comment("User5", "Awesome content!"));
        videos[2].AddComment(new Comment("User6", "Really enjoyed this."));

        // Display details for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.UserName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}

