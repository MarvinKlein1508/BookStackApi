using BookStackApi.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using System.Runtime;
using System.Text.Json.Serialization;

namespace BookStackApi
{
    public class BookStackService
    {
        private readonly IOptions<BookStackOptions> _options;

        public BookStackService(IOptions<BookStackOptions> options)
        {
            _options = options;
        }

        public async Task<T?> GetAsync<T>(int id) where T : class, IBookStackEntity, new()
        {
            using HttpClient client = new HttpClient();
            string urlForEntity = GetUrlForEntity(typeof(T), id);
            client.DefaultRequestHeaders.Add("Authorization", $"Token {_options.Value.Token}:{_options.Value.Secret}");
            return await client.GetFromJsonAsync<T>(urlForEntity);
        }

        public async Task<BookStackResponse<T>?> GetListAsync<T>(ListParameters? parameters = null) where T : class, IBookStackEntity, new()
        {
            using HttpClient client = new HttpClient();
            string text = GetUrlForEntity(typeof(T));
            if (parameters is not null)
            {
                text += parameters.AsQuery();
            }

            client.DefaultRequestHeaders.Add("Authorization", $"Token {_options.Value.Token}:{_options.Value.Secret}");
            return await client.GetFromJsonAsync<BookStackResponse<T>>(text);
        }

        private string GetUrlForEntity(Type type, int? id = null)
        {
            string text = $"{_options.Value.BaseUrl}{BookStackEntityAttribute.GetAttribute(type).Path}";
            if (!id.HasValue)
            {
                return text;
            }

            return $"{text}/{id.Value}";
        }

    }
}