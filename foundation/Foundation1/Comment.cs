public class Comment
{
    private string _author;
    private string _text;
    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }
    public string GetDisplayComment()
    {
        string commentDisplayed = $"{_author}: {_text}";
        return commentDisplayed;
    }


}