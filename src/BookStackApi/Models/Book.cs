using BookStackApi.Core;
using System.Text.Json.Serialization;

namespace BookStackApi
{

    [BookStackEntity("books")]
    public class Book : IBookStackEntity
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
        public UserDetails CreatedBy { get; set; } = new();
        [JsonPropertyName("updated_by")]
        public UserDetails UpdatedBy { get; set; } = new();
        [JsonPropertyName("owned_by")]
        public UserDetails OwnedBy { get; set; } = new();
        public BookContent[] Contents { get; set; } = Array.Empty<BookContent>();
        public Tag[] Tags { get; set; } = Array.Empty<Tag>(); 
        public Cover Cover { get; set; } = new();
    }

}
