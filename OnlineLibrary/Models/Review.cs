namespace OnlineLibrary.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string ReviewerName { get; set; }
        public string Content { get; set; }
        public DateTime ReviewDate { get; set; }

        public Book Book { get; set; }
    }
}
