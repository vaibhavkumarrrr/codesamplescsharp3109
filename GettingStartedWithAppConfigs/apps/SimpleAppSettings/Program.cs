using System.Configuration;

namespace SimpleAppSettings
{
    internal class Program
    {
        static void Main(string[] _)
        {
            foreach(var arg in ConfigurationManager.AppSettings)
            {
                Console.WriteLine("key: " + arg.ToString() + ", value: " + ConfigurationManager.AppSettings[arg.ToString()]);
            }
        }
    }
}
