public class Video
{
    // Member Variables
    public string _videoTitle;
    public string _videoAuthor;
    public int _videoLength;
    public List<Comment> _videoComments = new List<Comment>();

    // Constructors
    public Video()
    {
        
    }

    // Methods
    public void CommentsPerVideo()
    {
        int commentNumber = _videoComments.Count;
        Console.WriteLine($"This video has {commentNumber} comments.");
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"'{_videoTitle}' by: {_videoAuthor}");
        Console.WriteLine($"Video length: {_videoLength} seconds\n");
        CommentsPerVideo();

        foreach (Comment comment in _videoComments)
        {
            comment.CommentDisplay();
        }
    }
}