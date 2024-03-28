namespace Assignment3.Models
{
    public class Comments
    {
        public int? Id { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public int? Rating { get; set; }
        public string? Image { get; set; }
        public string? CommentText { get; set; }
    }
}
