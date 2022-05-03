namespace Forum4.Data;

public class Post
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTimeOffset CreatedDateTime { get; set; }
    public int UserId { get; set; }
    public int Id { get; set; }
}