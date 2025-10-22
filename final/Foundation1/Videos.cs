using YouTubeVideos;

public class Video
{
     // TODO: Create private fields to store title, author, and length (in seconds).
        // TODO: Create a private List<Comment> to store all comments for this video.
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;
    // TODO: Create a constructor to set the video’s title, author, and length.
    public Video(string title, string author, int lengthInSeconds)
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

        // TODO: Create a method to display the video’s details (title, author, length, number of comments).
        //       Inside this method, loop through the comment list and display each comment.
    }