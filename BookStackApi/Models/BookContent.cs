namespace BookStackApi
{
    public class BookContent : IBookStackEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public int book_id { get; set; }
        public int chapter_id { get; set; }
        public bool Draft { get; set; }
        public bool Template { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }

}
