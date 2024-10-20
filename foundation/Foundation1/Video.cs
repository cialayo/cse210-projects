public class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lenght = length;
        _comments = new List<Comment>();
    }
    public int CountComments()
    {
        int commentsQuantity = _comments.Count;
        return commentsQuantity;
    }
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public string GetDisplayVideo()
    {
        string videoDisplayed = $"Title: {_title}\nAuthor: {_author}\nLenght: {_lenght} seconds\nNumber of Comments: {CountComments()} comments";
        return videoDisplayed;
    }
    public string GetDisplayComments()
    {
        string commentsDisplayed = "";
        foreach (Comment comment in _comments)
        {
            commentsDisplayed += comment.GetDisplayComment() + "\n";
        }
        return commentsDisplayed;
    }
}