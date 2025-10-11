using System.Text.RegularExpressions;
namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = "asdads sdfdsf #burgers, #rabbits dsfsdfds #sdf #dfgdfg #sdf #sdf";
            var regex = new Regex(@"#\w+");
            var matches = regex.Matches(input);
            Dictionary<string, int> dict = new Dictionary<string, int>();

            // https://stackoverflow.com/questions/289/how-do-you-sort-a-dictionary-by-value 

            foreach (var match in matches)
            {
                var key = dict.ContainsKey(match.ToString()) ? match.ToString() : match.ToString().ToLower();
                if (dict.ContainsKey(key))
                {
                    dict[key]++;
                }
                else
                {
                    Console.WriteLine("****"+key); 
                    dict[key] = 1;
                }
            }
            //System.Collections.Generic.S
            var sortedDict = from entry in dict orderby entry.Value descending select entry;
            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
