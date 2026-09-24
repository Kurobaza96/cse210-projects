public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor to initialize the comment with name and text
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}