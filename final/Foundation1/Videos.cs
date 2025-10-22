using YouTubeVideos;

public class Video
{
    // TODO: Create private fields to store title, author, and length (in seconds).
    // TODO: Create a private List<Comment> to store all comments for this video.
    private string _title;
    private string _author;
    private double _lengthInSeconds;
    private List<Comment> _comments;
    // TODO: Create a constructor to set the video’s title, author, and length.
    public Video(string title, string author, double lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }
    // TODO: Create a method to add a Comment to the list.
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    // TODO: Create a method to return the number of comments.
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    //need this to display all comments for each video
    public List<Comment> GetComments()
    {
        return _comments;
    }
    // TODO: Create a method to display the video’s details (title, author, length, number of comments).
    public void DisplayVideoDetails()
    {
        Console.WriteLine($" {_title}, by {_author} is{_lengthInSeconds} seconds long and has {GetNumberOfComments()} comments.");
    }

 
}
    //https://byui-cse.github.io/cse210-course-2023/unit02/prepare.html