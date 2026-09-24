public class Video
{
    // Video properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }

    // List to hold comments for the video
    private List<Comment> _comments = new List<Comment>();

    // Constructor to initialize the video
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to get the list of comments
    public List<Comment> GetComments()
    {
        return _comments;
    }
}