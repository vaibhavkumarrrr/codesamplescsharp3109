using System.Configuration;

namespace ACrazyCatsExample
{
    public class Program
    {
        private static CatLadyConfigurationSection GetConfig()
        {
            return (CatLadyConfigurationSection)ConfigurationManager.GetSection("catLady");
        }
        public static void Main(string[] _)
        {
            var x = GetConfig();
            Console.WriteLine(x.Name);
            foreach (var catElement in x.Cats)
            {
                var cat = (CatConfiguration)catElement;
                var color = string.IsNullOrEmpty(cat.Color) ? "" : " color:" + cat.Color;
                var age = cat.Age; 
                Console.WriteLine($"Name: {cat.Name},color: {color}, Age: {age}");
            }

            Console.ReadLine();
        }
    }
}
