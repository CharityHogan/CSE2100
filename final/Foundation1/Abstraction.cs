using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Intro to C#", "Charity", 300);
        v1.AddComment(new Comment("Anna", "Great video!"));
        v1.AddComment(new Comment("Tom", "Very helpful."));
        v1.AddComment(new Comment("Liam", "Thanks for explaining clearly."));
        videos.Add(v1);

        Video v2 = new Video("OOP Concepts", "John", 450);
        v2.AddComment(new Comment("Mia", "Loved the examples."));
        v2.AddComment(new Comment("Sophia", "Clear and easy to follow."));
        videos.Add(v2);
        
        foreach (Video v in videos)
        {
            v.DisplayInfo();
            Console.WriteLine();
        }
    }
}

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");

        foreach (Comment c in _comments)
        {
            Console.WriteLine($" - {c.GetName()}: {c.GetText()}");
        }
    }
}

class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetName() => _name;
    public string GetText() => _text;
}
