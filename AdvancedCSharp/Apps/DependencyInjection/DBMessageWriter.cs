namespace DependencyInjection
{
    public class DBMessageWriter : IMessageWriter
    {
          public void Write(string message)
        {
            Console.WriteLine($"In a real life situation, I will insert this is into a database --> MessageWriter.Write(message: \"{message}\")");
        }
    }
}