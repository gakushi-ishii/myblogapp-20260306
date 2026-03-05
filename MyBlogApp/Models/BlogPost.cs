namespace MyBlogApp.Models;

public class BlogPost
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public DateTime PublishedAt { get; set; }
    public List<string> Tags { get; set; } = new();

    public string Summary => Content.Length > 200 ? Content[..200] + "..." : Content;
}
