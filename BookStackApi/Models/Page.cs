using BookStackApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookStackApi
{
    [BookStackEntity("pages")]
    public class Page : IBookStackEntity
    {
        public int Id { get; set; }
        [JsonPropertyName("book_id")]
        public int BookId { get; set; }
        [JsonPropertyName("chapter_id")]
        public int ChapterId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Html { get; set; } = string.Empty;
        public int Priority { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("created_by")]
        public UserDetails CreatedBy { get; set; } = new();
        [JsonPropertyName("updated_by")]
        public UserDetails UpdatedBy { get; set; } = new();
        public bool Draft { get; set; }
        public string Markdown { get; set; } = string.Empty;
        [JsonPropertyName("revision_count")]
        public int RevisionCount { get; set; }
        public bool Template { get; set; }
        [JsonPropertyName("owned_by")]
        public UserDetails OwnedBy { get; set; } = new();
        public string Editor { get; set; } = string.Empty;
        public string[] Tags { get; set; } = Array.Empty<string>();
    }

    

}
