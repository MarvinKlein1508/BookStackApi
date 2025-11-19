using BookStackApi.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStackApi
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddBookStack(this IServiceCollection collection, Action<BookStackOptions> config)
        {

            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (config == null) throw new ArgumentNullException(nameof(config));

            collection.Configure<BookStackOptions>(config);
            return collection.AddScoped<BookStackService>();
        }

        public static IServiceCollection AddBookStack(this IServiceCollection collection, IConfiguration config)
        {

            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (config == null) throw new ArgumentNullException(nameof(config));
            BookStackOptions? options = config.GetSection("BookStack").Get<BookStackOptions>();

            if (options is not null)
            {
                collection.Configure<BookStackOptions>(config =>
                {
                    config.BaseUrl = options.BaseUrl;
                    config.Token = options.Token;
                    config.Secret = options.Secret;
                });
            }
            return collection.AddScoped<BookStackService>();
        }
    }
}