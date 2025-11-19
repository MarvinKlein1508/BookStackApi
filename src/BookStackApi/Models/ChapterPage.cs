using System.Text.Json.Serialization;

namespace BookStackApi
{
    public class ChapterPage : IBookStackEntity
    {
        public int Id { get; set; }
        [JsonPropertyName("book_id")]
        public int BookId { get; set; }
        [JsonPropertyName("chapter_id")]
        public int ChapterId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public int Priority { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("created_by")]
        public int CreatedBy { get; set; }
        [JsonPropertyName("updated_by")]
        public int UpdatedBy { get; set; }
        public bool Draft { get; set; }
        [JsonPropertyName("revision_count")]
        public int RevisionCount { get; set; }
        public bool Template { get; set; }
        [JsonPropertyName("owned_by")]
        public int OwnedBy { get; set; }
        public string Editor { get; set; } = string.Empty;
        [JsonPropertyName("book_slug")]
        public string BookSlug { get; set; } = string.Empty;
    }

}
