namespace BookStackApi.Core
{
    public class BookStackOptions
    {
        public string BaseUrl { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
    }
}