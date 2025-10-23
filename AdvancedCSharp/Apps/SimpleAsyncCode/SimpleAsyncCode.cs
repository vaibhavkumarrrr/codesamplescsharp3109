namespace csharp.training.congruent.apps
{
    public class SimpleAsyncCode
    {
        private static readonly HttpClient httpClient = new();

        // Asynchronously fetch content from a URL
        public static async Task<string> FetchContentAsync(string url)
        {
            Console.WriteLine($"Starting download: {url}");
            string content = await httpClient.GetStringAsync(url);
            Console.WriteLine($"Completed download: {url}");
            return content;
        }

        // Asynchronously fetch multiple URLs in parallel
        public static async Task<List<string>> FetchMultipleAsync(List<string> urls)
        {
            var tasks = new List<Task<string>>();

            foreach (var url in urls)
            {
                tasks.Add(FetchContentAsync(url));
            }

            // Await all tasks to complete
            string[] results = await Task.WhenAll(tasks);
            return [.. results];
        }

        public static async Task Main(string[] _)
        {
            var urls = new List<string>
        {
            "https://example.com",
            "https://dotnet.microsoft.com",
            "https://learn.microsoft.com"
        };

         List<string> pages = await FetchMultipleAsync(urls);

          for (int i = 0; i < pages.Count; i++)
           {
                
                Console.WriteLine($"\n--- Content from {urls[i]} ---");
                Console.WriteLine(pages[i][..Math.Min(100, pages[i].Length)] + "...");
            }
        }
    }
}
