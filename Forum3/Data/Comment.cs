namespace Forum3.Data;

public class Comment
{
    public string Message { get; set; }
    public DateTimeOffset CreatedDateTime { get; set; }
    public int UserId { get; set; }
    public int PostId { get; set; }
    public int Id { get; set; }
}