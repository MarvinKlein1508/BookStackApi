using BookStackApi.Core;
using System.Text.Json.Serialization;

namespace BookStackApi
{
    [BookStackEntity("chapters")]
    public class Chapter : IBookStackEntity
    {
        public int Id { get; set; }
        [JsonPropertyName("book_id")]
        public int BookId { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Priority { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("created_by")]
        public UserDetails CreatedBy { get; set; } = new();
        [JsonPropertyName("updated_by")]
        public UserDetails UpdatedBy { get; set; } = new();
        [JsonPropertyName("owned_by")]
        public UserDetails OwnedBy { get; set; } = new();
        [JsonPropertyName("book_slug")]
        public string BookSlug { get; set; } = string.Empty;
        public Tag[] Tags { get; set; } = Array.Empty<Tag>();
        public ChapterPage[] Pages { get; set; } = Array.Empty<ChapterPage>();
    }

}
