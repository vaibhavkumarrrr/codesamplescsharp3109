namespace DependencyInjection
{

    public class DbMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"DB Based: In real world, send data to db instead of console ==>  MessageWriter.Write(message: \"{message}\")");
        }
    }
}