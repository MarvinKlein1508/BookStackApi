using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookStackApi.Tester
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(builder =>
            {
                builder.SetBasePath(AppDomain.CurrentDomain.BaseDirectory);
                builder.AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
                builder.AddJsonFile("appSettings.development.json", optional: true, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.AddBookStack(context.Configuration);
            })
            .Build();

            var bookstackService = ActivatorUtilities.GetServiceOrCreateInstance<BookStackService>(host.Services);

            var page = await bookstackService.GetAsync<Page>(46);

            var book = await bookstackService.GetAsync<Book>(26);

            var books = await bookstackService.GetListAsync<Book>();

         
        }
    }
}