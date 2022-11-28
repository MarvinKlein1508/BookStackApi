using System.Text.Json.Serialization;

namespace BookStackApi.Core
{
    public class BookStackResponse<T> where T : class, IBookStackEntity, new()
    {
        public BookstackEntry[] Data { get; set; } = Array.Empty<BookstackEntry>();

        public int Total { get; set; }
    }

    public class BookstackEntry
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("created_by")]
        public int CreatedBy { get; set; }
        [JsonPropertyName("updated_by")]
        public int UpdatedBy { get; set; }
        [JsonPropertyName("owned_by")]
        public int OwnedBy { get; set; }
    }
}
