namespace BookStackApi
{
    public class Cover : IBookStackEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int created_by { get; set; }
        public int updated_by { get; set; }
        public string Path { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int uploaded_to { get; set; }
    }

}
