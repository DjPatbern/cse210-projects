using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Walking You Through Nigeria", "Joy", 300);
        video1.AddComment(new Comment("Bern", "What an experience!"));
        video1.AddComment(new Comment("John", "Hi, I am from Lagos"));
        video1.AddComment(new Comment("Patrick", "I would love to visit"));

        Video video2 = new Video("How to prepare Afang soup", "Vicky", 240);
        video2.AddComment(new Comment("Tobi", "Amazing Recipe!"));
        video2.AddComment(new Comment("Nsikak", "Great meal"));
        video2.AddComment(new Comment("Peter", "I would love to have a test"));

        Video video3 = new Video("Software Development Roadmap", "Isaac", 360);
        video3.AddComment(new Comment("Akpan", "Insightful"));
        video3.AddComment(new Comment("Collins", "This was helpful"));
        video3.AddComment(new Comment("Victor", "I can't wait for the next video"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
