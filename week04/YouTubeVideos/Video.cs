using System.Net.Http.Headers;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentList = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }

    public int GetTotalComments()
    {
        return _commentList.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Total Comments: {GetTotalComments()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _commentList)
        {
            Console.WriteLine($" - {comment.DisplayText()}");
        }

        Console.WriteLine();

    }



}