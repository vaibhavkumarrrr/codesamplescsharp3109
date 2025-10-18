using Microsoft.Extensions.Logging;
namespace DependencyInjection
{
    public sealed class Worker(IMessageWriter messageWriter, ILogger<Worker> _logger) : Microsoft.Extensions.Hosting.BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                string message = $"Worker running at: {DateTimeOffset.Now}";
                //messageWriter.Write(message);
                //string message = $"""Message: {messageWriter}""";
                _logger.LogInformation("Worker running at: {time}",DateTimeOffset.Now);
                //_logger.LogDebug("**** And this is an example of a debug message");
                _logger.LogCritical("**** And a fatal Error");
                _logger.LogWarning("**** This is just a warning");
                await Task.Delay(1_000, stoppingToken);
            }
        }
    }
}