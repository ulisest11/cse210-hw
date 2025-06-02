using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial for Beginners", "CodeAcademy", 900);
        video1.AddComment(new Comment("Alice", "Great tutorial, thanks!"));
        video1.AddComment(new Comment("Bob", "Very helpful, learned a lot."));
        video1.AddComment(new Comment("Charlie", "Can you do one about LINQ?"));

        Video video2 = new Video("Top 10 Travel Destinations 2025", "Wanderlust", 600);
        video2.AddComment(new Comment("Dana", "Adding these to my bucket list!"));
        video2.AddComment(new Comment("Eli", "Beautiful places, thanks for sharing."));
        video2.AddComment(new Comment("Fiona", "I was just there last year!"));

        Video video3 = new Video("How to Bake a Chocolate Cake", "Baker's Delight", 450);
        video3.AddComment(new Comment("George", "This recipe looks delicious."));
        video3.AddComment(new Comment("Hannah", "Tried it today, turned out perfect."));
        video3.AddComment(new Comment("Ian", "What can I substitute for eggs?"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLength()}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine();
        }
    }
}
