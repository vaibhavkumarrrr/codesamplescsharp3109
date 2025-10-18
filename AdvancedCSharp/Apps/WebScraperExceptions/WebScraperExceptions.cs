using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace csharp.training.congruent.apps
{
    internal class WebScraperExceptions
    {
        private static readonly HttpClient httpClient = new();

        // Asynchronously fetch content from a URL with exception handling
        public static async Task<string> FetchContentAsync(string url)
        {
            try
            {
                Console.WriteLine($"Starting download: {url}");
                string content = await httpClient.GetStringAsync(url);
                Console.WriteLine($"Completed download: {url}");
                return content;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Network error while downloading {url}: {ex.Message}");
                throw; // Propagate to caller
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine($"Timeout or cancellation for {url}: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error for {url}: {ex.Message}");
                throw;
            }
        }

        // Asynchronously fetch multiple URLs in parallel with aggregated error handling
        public static async Task<List<string>> FetchMultipleAsync(List<string> urls)
        {
            var tasks = new List<Task<string>>();

            foreach (var url in urls)
            {
                tasks.Add(FetchContentAsync(url));
            }

            try
            {
                string[] results = await Task.WhenAll(tasks);
                return [.. results];
            }
            catch (AggregateException aggEx)
            {
                Console.WriteLine("One or more downloads failed:");
                foreach (var ex in aggEx.InnerExceptions)
                {
                    Console.WriteLine($" - {ex.GetType().Name}: {ex.Message}");
                }
                throw; // Optional: rethrow to propagate further
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General failure: {ex.Message}");
                throw;
            }
        }
        static async Task Main(string[] _)
        {
            var urls = new List<string>
        {
            "https://example.com",
            "https://dotnet.microsoft.com",
            "https://invalid-url-for-testing.com",
            "https://tiktok.com"// This will trigger an error
        };

            try
            {
                List<string> pages = await FetchMultipleAsync(urls);

                for (int i = 0; i < pages.Count; i++)
                {
                    Console.WriteLine($"\n--- Content from {urls[i]} ---");
                    Console.WriteLine(pages[i][..Math.Min(200, pages[i].Length)] + "...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"From Main --> Fatal error in scraping process: {ex.Message}");
            }
        }
    }
}
